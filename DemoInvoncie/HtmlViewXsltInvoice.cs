using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using iTextSharp.text;
using System.Drawing.Printing;

namespace DemoInvoncie
{
    public partial class HtmlViewXsltInvoice : DevExpress.XtraEditors.XtraForm
    {
        string _xsltMessage;
        public HtmlViewXsltInvoice(string xsltMessage)
        {
            InitializeComponent();
            _xsltMessage = xsltMessage;
        } 
        private void HtmlViewXsltInvoice_Load(object sender, EventArgs e)
        {
           // htmlContentControl1.HtmlTemplate.Template = _xsltMessage;
            webBrowser1.DocumentText = _xsltMessage;
        }  

        private void BtnPdfConvert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyaları|*.pdf";
            saveFileDialog.Title = "PDF Dosyasını Kaydet";

            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ConvertHtmlToPdf(_xsltMessage, saveFileDialog.FileName);
                MessageBox.Show("Dosyanız başarılı bir şekilde kaydedildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        } 
        static void ConvertHtmlToPdf(string htmlContent, string pdfFilePath)
        {
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);

                pdfDoc.Open();

                StringReader sr = new StringReader(htmlContent);
                HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                htmlparser.Parse(sr);

                pdfDoc.Close();
            }
        }

        private void BtnWriteDocumnet_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, args) =>
            {
                using (var stringToStream = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(_xsltMessage)))
                {
                    using (var webBrowser = new WebBrowser())
                    {
                        webBrowser.DocumentStream = stringToStream;
                        webBrowser.Print();
                    }
                }
            }; 
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
   
}
