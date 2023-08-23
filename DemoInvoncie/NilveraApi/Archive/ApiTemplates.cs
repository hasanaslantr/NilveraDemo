using Newtonsoft.Json;
using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoInvoncie.NilveraApi.Archive
{
    public class ApiTemplates
    {
        AuthorizationApi _authorization  = new AuthorizationApi();
        
       public async  Task<List<Templates>> GetTemplatesAsync()
        {
            using(HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add($"Authorization", $"Bearer {_authorization.ApiKey}");

                HttpResponseMessage respone = await client.GetAsync("https://apitest.nilvera.com/earchive/Templates?IsActive=true");

                if (respone.IsSuccessStatusCode)
                {
                    var jsonData = await respone.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<Templates>(jsonData);
                    var invoicesData = apiResponse.Content;

                    return invoicesData;
                }
                else { return new List<Templates>(); }
            }
        }
        
    }
     
}
