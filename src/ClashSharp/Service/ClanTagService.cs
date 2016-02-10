using ClashSharp.Interface;
using System;

namespace ClashSharp.Service
{
    public class ClanTagService : IClanTagService
    {
        public string EncodeClanTag(string clanTag)
        {
            // make sure our clan tag starts with a #
            if (clanTag.StartsWith("#") == false)
            {
                throw new ApplicationException("Clan tag starts with '#'");
            }

            // encode our clanTag
            return clanTag.Replace("#", "%23");
        }
    }
}
