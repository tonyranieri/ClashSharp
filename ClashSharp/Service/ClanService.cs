using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public IEnumerable<ClanMember> ListClanMembers(string clanTag)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClanInformation> SearchClans(ClanSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
