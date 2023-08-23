using DemoInvoncie.DevexpressConfigurations;
using DemoInvoncie.NilveraApi.Invoncie;
using System;
using System.Windows.Forms;

namespace DemoInvoncie
{
    public partial class EInvoice : DevExpress.XtraEditors.XtraForm
    {
        EInvoiceDraftList _draftList = new EInvoiceDraftList();
        GridAppearance _gridAppearance = new GridAppearance();

        public EInvoice()
        {
            InitializeComponent();
        }

        private async void EInvoice_Load(object sender, EventArgs e)
        {
            gridControlEInvocie.DataSource = await _draftList.DrafList();
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
    }
}
