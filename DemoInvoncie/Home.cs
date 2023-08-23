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
    }
}
