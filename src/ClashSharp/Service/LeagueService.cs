using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using System.Threading.Tasks;

namespace ClashSharp.Service
{
    public class LeagueService : ServiceBase, ILeagueService
    {
        public async Task<ListLeagueResponse> ListLeagues()
        {
            var result = await _apiClient.Get<ListLeagueResponse>(UrlConstants.ListLeagueUrlTemplate);
            return result;
        }
    }
}
