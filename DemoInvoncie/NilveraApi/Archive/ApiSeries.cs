using Newtonsoft.Json;
using NLayer.Entities.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static DemoInvoncie.NilveraApi.Invoncie.EInvoiceDraftList;

namespace DemoInvoncie.NilveraApi.Archive
{
    public class ApiSeries
    {
        AuthorizationApi _authorization = new AuthorizationApi();

        public async Task<List<Series>> SeriesAsync()
        {
            using (HttpClient client = new HttpClient())
            { 
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");
                 
                HttpResponseMessage respone = await client.GetAsync($"https://apitest.nilvera.com/earchive/Series?IsActive=true&IsDefault=false");
                if (respone.IsSuccessStatusCode)
                {
                    var jsonData = await respone.Content.ReadAsStringAsync();  
                    var apiResponse =  JsonConvert.DeserializeObject<Series>(jsonData);
                    var invoicesData = apiResponse.Content;

                    return invoicesData;
                }
                else { return new List<Series>(); }
            }
        }

    }

     
}
