using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IApiClient
    {
        Task<T> Get<T>(string url) where T : new();
    }
}
