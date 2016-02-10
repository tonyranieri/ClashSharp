using ClashSharp.Data;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IClanService
    {
        Task<SearchClanResult> SearchClans(ClanSearchCriteria criteria);
        Task<ClanInformation> GetClanInformation(string clanTag);
        Task<ListClanMembersResponse> ListClanMembers(string clanTag);
    }
}
