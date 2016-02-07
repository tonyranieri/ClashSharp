using System.Configuration;

namespace ClashSharp.Service
{
    public class ServiceBase
    {
        internal string _cocApiToken = ConfigurationManager.AppSettings["clashAPIKey"];
        internal HttpService _httpSvc = new HttpService();
    }
}
