using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInvoncie.Invoncie
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
            htmlContentControl1.HtmlTemplate.Template = _xsltMessage;

        }
    }
}
