using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoInvoncie.NilveraApi
{
    public class CompanyInfoGet
    {
        AuthorizationApi _authorization = new AuthorizationApi();

        public async Task<Company> CompanyInfoAsync()
        {
            try
            { 
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync("https://apitest.nilvera.com/general/Company");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Company>(jsonData);
                        var invoicesData = apiResponse.Content;
                        return invoicesData;
                    }
                    else
                    {
                        // API çağrısı başarısız oldu
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return null;
            }
        }

    }

    public class Company
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string PayeeFinancialAccountID { get; set; }
        public string PaymentMeansChannelCode { get; set; }
        public string PaymentMeansCode { get; set; }
        public Company Content { get; set; }
    } 
}
