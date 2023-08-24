using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoInvoncie.NilveraApi.Invoncie
{
    public class Purchase
    {
        AuthorizationApi _authorization = new AuthorizationApi();

        public async Task<string> HtmlAsync( string UUID)
        {

           
            try
            { 
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync($"https://apitest.nilvera.com/einvoice/Purchase/{UUID}/html");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync(); 
                        return jsonData;
                    }
                    else
                    { 
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
