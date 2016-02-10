using ClashSharp.Data;
using System.Collections.Generic;

namespace ClashSharp.Interface
{
    public interface ILocationService
    {
        IEnumerable<Location> ListLocations();
        Location GetLocationInformation(string locationId);
        IEnumerable<ClanRankInfo> GetClanRankForLocation(string locationId);
        IEnumerable<ClanMember> GetPlayerRankForLocation(string locationId);
    }
}
