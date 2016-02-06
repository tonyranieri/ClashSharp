using System.Collections.Generic;

namespace ClashSharp.Data
{
    public class ClanInformation
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public AssetUrls BadgeUrls { get; set; }
        public string WarFrequency { get; set; } //todo: enum?
        public int ClanLevel { get; set; }
        public int WarWins { get; set; }
        public int ClanPoints { get; set; }
        public int RequiredTrophies { get; set; }
        public int MemberCount { get; set; }
        public IEnumerable<ClanMember> Members { get; set; }
        public int Rank { get; set; }
        public int PreviousRank { get; set; }
    }
}
