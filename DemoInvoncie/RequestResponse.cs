using DemoInvoncie.NilveraApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoInvoncie
{
    public class RequestResponse<T> where T : class
    {
        AuthorizationApi _authorization = new AuthorizationApi();

        public async Task<List<T>> GetListAsync(string link)
        {
            try
            { 
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}"); 
                    HttpResponseMessage response = await client.GetAsync(link);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<ApiModel<T>>(jsonData);
                        var invoicesData = apiResponse.Content;
                        return invoicesData;
                    }
                    else
                        throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        } 
        public async Task<List<T>> GetListNoContextAsync(string link)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}"); 
                    HttpResponseMessage response = await client.GetAsync(link);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(jsonData); 
                        return apiResponse;
                    }
                    else
                        throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<T> GetModelAsync(string link)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync(link);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonData);
                        return apiResponse;
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> GetStringAsync(string link)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authorization.ApiKey}");

                    HttpResponseMessage response = await client.GetAsync(link);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

    public class ApiModel<T> where T : class
    {
        public List<T> Content { get; set; }
    }

}
