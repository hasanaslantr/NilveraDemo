using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace DemoInvoncie.NilveraApi.EInvoncies
{
    public class EInvoiceDraftList
    {
        AuthorizationApi _authorization = new AuthorizationApi();

        public async Task<List<Invoice>> DrafList()
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync("https://apitest.nilvera.com/einvoice/Draft?PageSize=30&Page=1");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<EInvoiceList>(jsonData);
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

}
