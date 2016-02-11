using ClashSharp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface ILocationService
    {
        Task<ListLocationResponse> ListLocations();
        Task<Location> GetLocationInformation(int locationId);
        Task<ClanRankForLocationResponse> GetClanRankForLocation(int locationId);
        IEnumerable<ClanMember> GetPlayerRankForLocation(int locationId);
    }
}
