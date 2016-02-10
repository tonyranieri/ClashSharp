namespace ClashSharp.Data
{
    public class ClanSearchCriteria
    {
        public ClanSearchCriteria()
        {
            Name = null;
            WarFrequency = null;
        }

        public string Name { get; set; }
        public string WarFrequency { get; set; }
        public int? LocationId { get; set; }
        public int? MinimumMembers { get; set; }
        public int? MaximumMembers { get; set; }
        public int? MinimumClanPoints { get; set; }
        public int? MinimumClanLevel { get; set; }
        public int? ResponseCount { get; set; }
        public int? Limit { get; set; }
        public int? ItemsAfter { get; set; }
        public int? ItemsBefore { get; set; }
    }
}
