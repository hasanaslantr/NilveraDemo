using DemoInvoncie.Convert;
using DemoInvoncie.DevexpressConfigurations;
using DemoInvoncie.NilveraApi.Invoncie;
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
    public partial class EInvoice : DevExpress.XtraEditors.XtraForm
    {
        EInvoiceDraftList _draftList = new EInvoiceDraftList();
        GridAppearance _gridAppearance = new GridAppearance();

        Purchase _purchase = new Purchase();

        public EInvoice()
        {
            InitializeComponent();
        }

        RequestResponse<Invoice>  _response = new RequestResponse<Invoice>();  
        List<Invoice> _invoices;
        ConvertModelToXml<Invoice> convertModelToXml = new ConvertModelToXml<Invoice>();
        private async void EInvoice_Load(object sender, EventArgs e)
        {
            _invoices = await _response.GetListAsync("https://apitest.nilvera.com/einvoice/Draft?PageSize=30&Page=1");
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
            var selectedInvoice = _invoices.FirstOrDefault(x => x.UUID == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UUID")?.ToString());  
            convertModelToXml.ModelToXml(selectedInvoice); 
        }
         

        private async void MenuStripAppreanceInvoncie_Click(object sender, EventArgs e)
        {
            
            var UUID = "00155D00-1100-1EDE-90BC-B026E3D8C10D";

            var uuid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UUID")?.ToString(); 

            HtmlViewXsltInvoice htmlView = new HtmlViewXsltInvoice(await _response.GetStringAsync($"https://apitest.nilvera.com/einvoice/Purchase/{UUID}/html"));
            htmlView.ShowDialog();

            /*
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
            }*/
        }
    }
}
