using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashSharp.Service
{
    public class LocationService : ServiceBase, ILocationService
    {
        public IEnumerable<ClanRankInfo> GetClanRankForLocation(string locationId)
        {
            throw new NotImplementedException();
        }

        public Location GetLocationInformation(string locationId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClanMember> GetPlayerRankForLocation(string locationId)
        {
            throw new NotImplementedException();
        }

        public async Task<ListLocationResponse> ListLocations()
        {
            var result = await _apiClient.Get<ListLocationResponse>(UrlConstants.ListLocationsUrlTemplate);
            return result;
        }
    }
}
