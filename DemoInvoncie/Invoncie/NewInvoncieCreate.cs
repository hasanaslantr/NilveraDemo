using DemoInvoncie.DevexpressConfigurations;
using DemoInvoncie.NilveraApi;
using DemoInvoncie.NilveraApi.Archive;
using DemoInvoncie.NilveraApi.General;
using Newtonsoft.Json;
using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoInvoncie
{
    public partial class NewInvoncieCreate : DevExpress.XtraEditors.XtraForm
    {
        public NewInvoncieCreate()
        {
            InitializeComponent();
        }
        GridAppearance _gridAppearance = new GridAppearance(); 
        CompanyInfoGet _companyInfoGet = new CompanyInfoGet(); 
        RequestResponse<GlobalCompany> _response =new RequestResponse<GlobalCompany>(); 
        ArchiveType _archiveType;
        InvoncieType _invoncieType; 
        private async void txtTaxNumber_EditValueChanged(object sender, EventArgs e)
        {
            await TaskNumberGetCompanyList(txtTaxNumber.Text);
        }

        private async System.Threading.Tasks.Task TaskNumberGetCompanyList(string _taxNumber)
        {
            if (_taxNumber.Length >= 10 && _taxNumber.Length <= 11)
            { 
                var globalCompany = await _response.GetModelAsync($"https://apitest.nilvera.com/general/GlobalCompany/GetGlobalCustomerInfo/{_taxNumber}?globalUserType=Invoice");

                if (globalCompany != null)
                {
                    txtTaxDepartment.Text = globalCompany.TaxDepartment;
                    txtTitle.Text = globalCompany.Title;
                    txtPhone.Text = globalCompany.Phone;
                    txtFax.Text = globalCompany.Fax;
                    txtEmail.Text = globalCompany.Email;
                    txtPostalCode.Text = globalCompany.PostalCode;
                    txtWebSite.Text = globalCompany.WebSite;
                    txtAddress.Text = globalCompany.Address;
                    txtCity.Text = globalCompany.City;
                    txtConrty.Text = globalCompany.Country;
                    txtDistrict.Text = globalCompany.District;

                    if (globalCompany.ModuleType == "eArchive")
                    {
                        BtnGib.Text = "e-Arşiv";
                        BtnGib.BackColor = Color.FromArgb(255, 128, 0);
                        flowLayoutPanel1.Controls.Clear();
                        _archiveType = new ArchiveType();
                        flowLayoutPanel1.Controls.Add(_archiveType);

                    }
                    else
                    {
                        BtnGib.Text = "e-Fatura";
                        BtnGib.BackColor = Color.FromArgb(0, 192, 0);
                        flowLayoutPanel1.Controls.Clear();
                        _invoncieType = new InvoncieType();
                        flowLayoutPanel1.Controls.Add(_invoncieType);


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
                var globalCompany = await _response.GetListNoContextAsync("https://apitest.nilvera.com/general/GlobalCompany/Search/" + searchControl1.Text);
                if (globalCompany.Count > 0)
                {
                    foreach (var item in globalCompany)
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
                string[] parts = selectedText.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string taskNumber = parts[1];

                    await TaskNumberGetCompanyList(taskNumber);

                }
            }
        }

        private async void BtnPost_Click(object sender, EventArgs e)
        {

            #region InvoiceInfo  
            var InvoiceInfo = new InvoiceInfo
            {
                UUID = Guid.NewGuid().ToString(),
                TemplateUUID = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                InvoiceType = _archiveType.gridLookUpEditInvoiceType.EditValue.ToString(), //Fatura Türü
                InvoiceSerieOrNumber = _archiveType.gridLookUpEditInvoiceSeries.EditValue.ToString(), //Fatura Serisi veya Numarası
                IssueDate = DateTime.UtcNow,
                CurrencyCode = _archiveType.gridLookUpEditCurrencyCode.EditValue.ToString(),//Para Birimi
              //  ExchangeRate = .ToDecimal(_archiveType.txtExchangeRate.Text), //Döviz Kuru
                ISDespatch = false, //Despatch Durumu
                SalesPlatform = _archiveType.gridLookUpEditSalesPlatform.EditValue.ToString(), //Satış Platformu
                SendType = _archiveType.gridLookUpEditSendType.ToString(), //Gönderi Türü 
                AccountingCost = "", //Muhasebe Maliyeti 
                LineExtensionAmount = 10, //Satır Genişletme Tutarı
                GeneralKDV1Total = 10, //Genel KDV 1 Toplamı
                GeneralKDV8Total = 10, //Genel KDV 8 Toplamı
                GeneralKDV18Total = 10, //Genel KDV 18 Toplamı
                GeneralKDV10Total = 10, //Genel KDV 10 Toplamı
                GeneralKDV20Total = 10, //Genel KDV 20 Toplamı
                GeneralAllowanceTotal = 10, //Genel İndirim Toplamı
                PayableAmount = 10, //Ödenebilir Tutar
                KdvTotal = 10 //KDV Toplamı

            };
            #endregion

            #region CompanyInfo   
            var _company = new CompanyInfo();
            var company = await _companyInfoGet.CompanyInfoAsync();
            _company.Name = company.Name; // İsim
            _company.TaxOffice = company.TaxOffice; // Vergi Dairesi
            _company.Address = company.Address; // Adres
            _company.District = company.District; // İlçe
            _company.City = company.City; // Şehir
            _company.Country = company.Country; // Ülke
            _company.PostalCode = company.PostalCode; // Posta Kodu
            _company.Phone = company.PhoneNumber; // Telefon
            _company.Fax = company.Fax; // Faks
            _company.Mail = company.Email; // E-posta
            _company.WebSite = company.WebSite; // Web Sitesi  
            #endregion

            #region CustomerInfo  
            var CustomerInfo = new CustomerInfo
            {
                TaxNumber = txtTaxNumber.Text, // Vergi Numarası
                Name = txtTitle.Text, // İsim
                TaxOffice = txtTaxDepartment.Text, // Vergi Dairesi
                Address = txtAddress.Text, // Adres
                District = txtDistrict.Text, // İlçe
                City = txtCity.Text, // Şehir
                Country = txtConrty.Text, // Ülke
                PostalCode = txtPostalCode.Text, // Posta Kodu
                Phone = txtPhone.Text, // Telefon
                Fax = txtFax.Text, // Faks
                Mail = txtEmail.Text, // E-posta
                WebSite = txtWebSite.Text // Web Sitesi
            };

            #endregion



            #region InvoiceLine İnfo

            var InvoiceLine = new List<InvoiceLine>
            {
                new InvoiceLine
                {
                     Index = "1", // İndeks
                SellerCode = "1", // Satıcı Kodu
                BuyerCode = "1", // Alıcı Kodu
                Name = "Klavye", // İsim
                Description = "", // Açıklama
                Quantity = 0, // Miktar
                UnitType = "", // Birim Türü
                Price = 0, // Fiyat
                AllowanceTotal = 0, // İndirim Toplamı
                KDVPercent = 0, // KDV Yüzdesi
                KDVTotal = 0, // KDV Toplamı
                Taxes = new List<Tax>(), // Vergiler
                ManufacturerCode = "", // Üretici Kodu
                BrandName = "", // Marka Adı
                ModelName = "", // Model Adı
                Note = "", // Not
                OzelMatrahReason = "", // Özel Matrah Nedeni
                OzelMatrahTotal = 0, // Özel Matrah Toplamı
                VatAmountWithoutTevkifat = 0, // Tevkifatsız KDV Miktarı
                AdditionalItemIdentification = new AdditionalItemIdentification() // Ek Ürün Kimliği
                },

            };


            #endregion



            /*



            try
            {
                AuthorizationApi authorizationApi = new AuthorizationApi();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {authorizationApi.ApiKey}");

                    var apiUrl = "https://apitest.nilvera.com/earchive/Send/Model"; // API URL'nizi buraya ekleyin

                    var sendInvoiceRequest = new SendInvoiceRequest
                    {

                    };

                    var jsonRequest = JsonSerializer.Serialize(sendInvoiceRequest);
                    var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("POST isteği başarılı! Cevap:");
                        Console.WriteLine(responseContent);
                    }
                    else
                    {
                        Console.WriteLine("POST isteği başarısız! Hata:");
                        Console.WriteLine(responseContent);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }


            */

        }
    }
}
