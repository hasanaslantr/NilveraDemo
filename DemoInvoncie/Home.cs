using System.Windows.Forms;

namespace DemoInvoncie
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnNewCreateInvonice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewInvoncieCreate newInvoncie = new NewInvoncieCreate();
            newInvoncie.ShowDialog();
        }

        private void BtnInvoiceDraft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EInvoice eInvoice = new EInvoice();
            eInvoice.MdiParent = this;
            eInvoice.Show();
        }

        private void Home_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
