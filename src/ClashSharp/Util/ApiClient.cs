using ClashSharp.Interface;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace ClashSharp.Util
{
    public class ApiClient : IApiClient
    {
        private HttpService _httpSvc = new HttpService();
        private string _cocApiToken = ConfigurationManager.AppSettings["clashAPIKey"];

        public async Task<T> Get<T>(string url) where T : new()
        {
            string jsonData = string.Empty;
            var returnValue = new T();

            try
            {
                jsonData = await _httpSvc.GetJsonAsync(_cocApiToken, url);
                returnValue = JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return returnValue;
        }
    }
}
