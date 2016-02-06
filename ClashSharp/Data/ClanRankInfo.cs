namespace ClashSharp.Data
{
    public class ClanRankInfo
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public AssetUrls BadgeUrls { get; set; }
        public int ClanLevel { get; set; }
        public int Members { get; set; }
        public int ClanPoints { get; set; }
        public int Rank { get; set; }
        public int PreviousRank { get; set; }
    }
}
