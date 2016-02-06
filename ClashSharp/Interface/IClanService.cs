using ClashSharp.Data;
using System.Collections.Generic;

namespace ClashSharp.Interface
{
    public interface IClanService
    {
        IEnumerable<ClanInformation> SearchClans(ClanSearchCriteria criteria);
        ClanInformation GetClanInformation(string clanTag);
        IEnumerable<ClanMember> ListClanMembers(string clanTag);
    }
}
