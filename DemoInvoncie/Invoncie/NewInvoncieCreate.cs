using DemoInvoncie.DevexpressConfigurations;
using DemoInvoncie.NilveraApi.General;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoInvoncie
{
    public partial class NewInvoncieCreate : DevExpress.XtraEditors.XtraForm
    {
        public NewInvoncieCreate()
        {
            InitializeComponent();
        }
        GridAppearance _gridAppearance = new GridAppearance();
        GlobalCompanySearch _company = new GlobalCompanySearch();

        private async void txtTaxNumber_EditValueChanged(object sender, EventArgs e)
        {
            await TaskNumberGetCompanyList(txtTaxNumber.Text);
        }

        private async System.Threading.Tasks.Task TaskNumberGetCompanyList(string _taxNumber)
        {
            if (_taxNumber.Length >= 10 && _taxNumber.Length <= 11)
            {
                var item = await _company.GlobalCompanyTaxNumberList(_taxNumber.Trim());

                if (item != null)
                {
                    txtTaxDepartment.Text = item.TaxDepartment;
                    txtTitle.Text = item.Title;
                    txtPhone.Text = item.Phone;
                    txtFax.Text = item.Fax;
                    txtEmail.Text = item.Email;
                    txtPostalCode.Text = item.PostalCode;
                    txtWebSite.Text = item.WebSite;
                    txtAddress.Text = item.Address;
                    txtCity.Text = item.City;
                    txtConrty.Text = item.Country;
                    txtDistrict.Text = item.District;

                    if (item.ModuleType == "eArchive")
                    {
                        BtnGib.Text = "e-Arşiv";
                        BtnGib.BackColor = Color.FromArgb(255, 128, 0);
                        flowLayoutPanel1.Controls.Clear();
                        ArchiveType archiveType = new ArchiveType();
                        flowLayoutPanel1.Controls.Add(archiveType);

                    }
                    else
                    {
                        BtnGib.Text = "e-Fatura";
                        BtnGib.BackColor = Color.FromArgb(0, 192, 0);
                        flowLayoutPanel1.Controls.Clear();
                        InvoncieType invoncieType = new InvoncieType();
                        flowLayoutPanel1.Controls.Add(invoncieType);


                    }
                }

                if (_taxNumber.Length == 0)
                {
                    foreach (Control controller in groupControl3.Controls)
                    {
                        if (controller is TextBox txtBox)
                        {
                            txtBox.Text = "";
                        }
                    }
                }
            }
        }

        private async void searchControl1_TextChanged(object sender, EventArgs e)
        {
            if (searchControl1.Text.Length >= 4)
            {
                var searchResults = await _company.GlobalCompanySearchList(searchControl1.Text);
                if (searchResults.Count > 0)
                {
                    foreach (var item in searchResults)
                    {
                        string combinedValue = $"{item.Title} - {item.TaxNumber}";
                        searchControl1.Properties.Items.Add(combinedValue);
                    }
                }
            }
            if (searchControl1.Text.Length < 4)
                searchControl1.Properties.Items.Clear();
        }

        private void ContextMenuAppreanceSave_Click(object sender, EventArgs e)
        {
            _gridAppearance.GridSave(this.Name, gridControlSales);
        }

        private void NewInvoncieCreate_Load(object sender, EventArgs e)
        {
            _gridAppearance.GridApp(this.Name, gridControlSales);
        }

        private async void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (searchControl1.SelectedIndex >= 0) // Bir öğe seçildiyse
            {
                string selectedText = searchControl1.SelectedItem.ToString();
                // Seçilen öğenin metnini analiz etmek ve TaskNumber'ı elde etmek için gerekli kod
                string[] parts = selectedText.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2) 
                {
                    string taskNumber = parts[1];

                    await TaskNumberGetCompanyList(taskNumber);

                }
            }
        } 


    }
}
