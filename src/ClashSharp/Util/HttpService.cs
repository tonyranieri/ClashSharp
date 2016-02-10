using ClashSharp.Interface;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClashSharp.Util
{
    internal class HttpService : IHttpService
    {
        public async Task<string> GetJsonAsync(string token, string url)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await client.GetStringAsync(url);
            return result;
        }
    }
}
