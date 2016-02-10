using ClashSharp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface ILocationService
    {
        Task<ListLocationResponse> ListLocations();
        Location GetLocationInformation(string locationId);
        IEnumerable<ClanRankInfo> GetClanRankForLocation(string locationId);
        IEnumerable<ClanMember> GetPlayerRankForLocation(string locationId);
    }
}
