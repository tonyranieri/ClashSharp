using ClashSharp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface IClanService
    {
        IEnumerable<ClanInformation> SearchClans(ClanSearchCriteria criteria);
        Task<ClanInformation> GetClanInformation(string clanTag);
        Task<ListClanMembersResponse> ListClanMembers(string clanTag);
    }
}
