using ClashSharp.Data;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface ILeagueService
    {
        Task<ListLeagueResponse> ListLeagues();
    }
}
