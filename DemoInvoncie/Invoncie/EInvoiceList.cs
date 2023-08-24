using DemoInvoncie.DevexpressConfigurations;
using DemoInvoncie.Invoncie;
using DemoInvoncie.NilveraApi.EInvoncies; 
using DevExpress.XtraEditors;
using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace DemoInvoncie
{
    public partial class EInvoiceList : DevExpress.XtraEditors.XtraForm
    {
        EInvoiceDraftList _draftList = new EInvoiceDraftList();
        GridAppearance _gridAppearance = new GridAppearance();

        public EInvoiceList()
        {
            InitializeComponent();
        }

        public List<EInvoiceList> _invoices = new List<EInvoiceList>();
        private async void EInvoice_Load(object sender, EventArgs e)
        {
            _invoices = await _draftList.DrafList();
            gridControlEInvocie.DataSource = _invoices;
            _gridAppearance.GridApp(this.Name, gridControlEInvocie);


        }

        private void MenuStripAppearanceSave_Click(object sender, EventArgs e)
        {
            _gridAppearance.GridSave(this.Name, gridControlEInvocie);
        }

        private void BtnInvocieSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili Faturaları gönderme işlemleri yapılacak!!!", "Bilgi Mesajı", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void ContextMenuXmlConverting_Click(object sender, EventArgs e)
        {
            var uuid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UUID")?.ToString();
            var invoiceNumber = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "InvoiceNumber")?.ToString();
            var taxNumber = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TaxNumber")?.ToString();

            var select = _invoices.Where(x => x.UUID == uuid).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Invoice>));

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files|*.xml";
                saveFileDialog.Title = "Save XML File";
                saveFileDialog.FileName = taxNumber + "_" + invoiceNumber;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (TextWriter writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, select);
                    }

                    MessageBox.Show("Dosyanız başarılı bir şekilde kaydedildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void MenuStripAppreanceInvoncie_Click(object sender, EventArgs e)
        {
            var uuid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UUID")?.ToString();
            var selectedInvoice = _invoices.FirstOrDefault(x => x.UUID == uuid);

            if (selectedInvoice != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
                using (StringWriter stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, selectedInvoice);
                    string xmlContent = stringWriter.ToString();

                    var xsltPath = @"InvoiceTemplate/transform.xslt"; // XSLT şablonunun

                    var xslTransform = new XslCompiledTransform();
                    xslTransform.Load(xsltPath);

                    using (StringWriter resultWriter = new StringWriter())
                    {
                        using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlContent)))
                        {
                            xslTransform.Transform(xmlReader, null, resultWriter);
                        }

                        string transformedContent = resultWriter.ToString();
                        HtmlViewXsltInvoice htmlView = new HtmlViewXsltInvoice(transformedContent);
                        htmlView.ShowDialog();
                    }
                }
            }
            else
            {
                Console.WriteLine("Belirtilen UUID'ye sahip Invoice bulunamadı.");
            }

        }

    }
}
