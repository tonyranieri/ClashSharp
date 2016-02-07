using ClashSharp.Constants;
using ClashSharp.Data;
using ClashSharp.Interface;
using System;
using System.Collections.Generic;

namespace ClashSharp.Service
{
    public class ClanService : ServiceBase, IClanService
    {
        private string EncodeClanTag(string clanTag)
        {
            // make sure our clan tag starts with a #
            if (clanTag.StartsWith("#") == false)
            {
                if(clanTag.StartsWith("%23") == false)
                {
                    clanTag = "#" + clanTag;
                }
                else
                {
                    // it appears our clan tag is already URL encoded so just return it
                    return clanTag;
                }
            }

            // encode our clanTag
            return clanTag;
        }

        public ClanInformation GetClanInformation(string clanTag)
        {
            var encodedClanTag = EncodeClanTag(clanTag);
            var url = string.Format(UrlConstants.GetClanInformationUrlTemplate, encodedClanTag);

            //var result = _httpSvc.GetJsonAsync(_cocApiToken, string.Empty);

            return new ClanInformation();
            //throw new NotImplementedException();
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
