using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IHttpService
    {
        Task<string> GetJsonAsync(string token, string url);
    }
}
