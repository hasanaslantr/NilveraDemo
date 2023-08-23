using System;
using System.Windows.Forms;

namespace DemoInvoncie
{
    public partial class InvoncieType : UserControl
    {
        public InvoncieType()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void InvoncieType_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
        }
    }
}
