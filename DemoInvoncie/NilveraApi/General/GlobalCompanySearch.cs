using Newtonsoft.Json;
using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoInvoncie.NilveraApi.General
{
    public class GlobalCompanySearch
    {
        AuthorizationApi _authorization = new AuthorizationApi();
        public async Task<List<GlobalCompany>> GlobalCompanySearchList(string search)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync("https://apitest.nilvera.com/general/GlobalCompany/Search/" + search);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        List<GlobalCompany> apiResponseList = JsonConvert.DeserializeObject<List<GlobalCompany>>(jsonData);
                        return apiResponseList;
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


        public async Task<GlobalCompany> GlobalCompanyTaxNumberList(string taskNumber)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync($"https://apitest.nilvera.com/general/GlobalCompany/GetGlobalCustomerInfo/{taskNumber}?globalUserType=Invoice");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();

                        GlobalCompany apiResponseList = JsonConvert.DeserializeObject<GlobalCompany>(jsonData);
                        return apiResponseList;


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
