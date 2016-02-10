using ClashSharp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface ILocationService
    {
        Task<ListLocationResponse> ListLocations();
        Task<Location> GetLocationInformation(int locationId);
        IEnumerable<ClanRankInfo> GetClanRankForLocation(string locationId);
        IEnumerable<ClanMember> GetPlayerRankForLocation(string locationId);
    }
}
