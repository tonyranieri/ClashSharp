using ClashSharp.Data;
using System.Threading.Tasks;

namespace ClashSharp.Interface
{
    public interface ILocationService
    {
        Task<ListLocationResponse> ListLocations();
        Task<Location> GetLocationInformation(int locationId);
        Task<ClanRankForLocationResponse> GetClanRankForLocation(int locationId);
        Task<PlayerRankForLocationResponse> GetPlayerRankForLocation(int locationId);
    }
}
