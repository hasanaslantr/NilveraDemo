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
using NLayer.Entities.Models;
using DemoInvoncie.ConvertProcess;

namespace DemoInvoncie
{
    public partial class HtmlViewXsltInvoice : DevExpress.XtraEditors.XtraForm
    {
        string _xsltMessage;

        ConvertStringToPdf _convertStringToPdf = new ConvertStringToPdf();
        RequestResponse<Invoice> _response = new RequestResponse<Invoice>();

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

        private async void BtnPdfConvert_Click(object sender, EventArgs e)
        {
            var link = "https://apitest.nilvera.com/einvoice/Purchase/00155D00-1100-1EDE-90BC-B026E3D8C10D/pdf";
            await _convertStringToPdf.stringToPdfAsync(await _response.GetStringAsync(link));
        }  
    }

}
