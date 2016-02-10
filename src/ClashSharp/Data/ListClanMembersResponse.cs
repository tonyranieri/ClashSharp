using System.Collections.Generic;

namespace ClashSharp.Data
{
    public class ListClanMembersResponse
    {
        /// <summary>
        /// A collection of clan members
        /// </summary>
        public IEnumerable<ClanMember> Items { get; set; }
    }
}
