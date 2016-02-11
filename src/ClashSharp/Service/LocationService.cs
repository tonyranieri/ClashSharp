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
        public async Task<ClanRankForLocationResponse> GetClanRankForLocation(int locationId)
        {
            var url = string.Format(UrlConstants.GetClanRankForLocationUrlTemplate, locationId);
            var result = await _apiClient.Get<ClanRankForLocationResponse>(url);
            return result;
        }   

        public async Task<Location> GetLocationInformation(int locationId)
        {
            var url = string.Format(UrlConstants.GetLocationInformationUrlTemplate, locationId);
            var result = await _apiClient.Get<Location>(url);
            return result;
        }

        public async Task<PlayerRankForLocationResponse> GetPlayerRankForLocation(int locationId)
        {
            var url = string.Format(UrlConstants.GetPlayerRankForLocationUrlTemplate, locationId);
            var result = await _apiClient.Get<PlayerRankForLocationResponse>(url);
            return result;
        }

        public async Task<ListLocationResponse> ListLocations()
        {
            var result = await _apiClient.Get<ListLocationResponse>(UrlConstants.ListLocationsUrlTemplate);
            return result;
        }
    }
}
