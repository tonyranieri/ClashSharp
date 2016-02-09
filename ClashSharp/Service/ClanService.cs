using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ClashSharp.Service
{
    public class ClanService : ServiceBase, IClanService
    {
        private IClanTagService _clanTagSvc = new ClanTagService();

        public async Task<ClanInformation> GetClanInformation(string clanTag)
        {
            var encodedClanTag = _clanTagSvc.EncodeClanTag(clanTag);
            var url = string.Format(UrlConstants.GetClanInformationUrlTemplate, encodedClanTag);

            string jsonData = string.Empty;
            ClanInformation clanInfo = new ClanInformation();

            try
            {
                jsonData = await _httpSvc.GetJsonAsync(_cocApiToken, url);
                clanInfo = JsonConvert.DeserializeObject<ClanInformation>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return clanInfo;
        }

        public async Task<ListClanMembersResponse> ListClanMembers(string clanTag)
        {
            var encodedClanTag = _clanTagSvc.EncodeClanTag(clanTag);
            var url = string.Format(UrlConstants.ListClanMembersUrlTemplate, encodedClanTag);

            string jsonData = string.Empty;
            var returnValue = new ListClanMembersResponse();

            try
            {
                jsonData = await _httpSvc.GetJsonAsync(_cocApiToken, url);
                returnValue = JsonConvert.DeserializeObject<ListClanMembersResponse>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return returnValue;
        }

        public async Task<SearchClanResult> SearchClans(ClanSearchCriteria criteria)
        {
            // validate the search criteria
            // name must be at least 3 chars long

            //https://api.clashofclans.com/v1/clans?name=gondor&warFrequency=moreThanOncePerWeek"

            throw new NotImplementedException();
        }
    }
}
