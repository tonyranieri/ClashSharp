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

            var result = await CallApi<ClanInformation>(_cocApiToken, url);
            return result;
        }

        public async Task<ListClanMembersResponse> ListClanMembers(string clanTag)
        {
            var encodedClanTag = _clanTagSvc.EncodeClanTag(clanTag);
            var url = string.Format(UrlConstants.ListClanMembersUrlTemplate, encodedClanTag);

            var result = await CallApi<ListClanMembersResponse>(_cocApiToken, url);
            return result;
        }

        public async Task<SearchClanResult> SearchClans(ClanSearchCriteria criteria)
        {
            IClanSearchCriteriaService criteriaSvc = new ClanSearchCriteriaService();

            var queryString = criteriaSvc.BuildQueryStringFromCriteria(criteria);
            var url = string.Format(UrlConstants.SearchClansUrlTemplate, queryString);

            var result = await CallApi<SearchClanResult>(_cocApiToken, url);
            return result;
        }

        private async Task<T> CallApi<T>(string cocApiToken, string url) where T : new()
        {
            string jsonData = string.Empty;
            var returnValue = new T();

            try
            {
                jsonData = await _httpSvc.GetJsonAsync(_cocApiToken, url);
                returnValue = JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return returnValue;
        }
    }
}
