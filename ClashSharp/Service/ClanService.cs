using ClashSharp.Data;
using ClashSharp.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace ClashSharp.Service
{
    public class ClanService : IClanService
    {
        public ClanInformation GetClanInformation(string clanTag)
        {
            throw new NotImplementedException();
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
