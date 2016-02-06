namespace ClashSharp.Data
{
    public class ClanMember
    {
        public string Name { get; set; }
        public string Role { get; set; } //todo: enum?
        public int ExperienceLevel { get; set; }
        public League League { get; set; }
        public int Trophies { get; set; }
        public int ClanRank { get; set; }
        public int PreviousClanRank { get; set; }
        public int Donations { get; set; }
        public int DonationsReceived { get; set; }
        public int AttackWins { get; set; }
        public int DefenseWins { get; set; }
        public int Rank { get; set; }
        public int PreviousRank { get; set; }
        public ClanInformation Clan { get; set; }
    }
}
