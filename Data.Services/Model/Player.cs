using System;
using System.Collections.Generic;

namespace Data.Services.Model
{
    public class Player
    {
        public string Tag { get; set; }
        public Id Id { get; set; }
        public string Name { get; set; }
        public string NameColorCode { get; set; }
        public long BrawlersUnlocked { get; set; }
        public long Victories { get; set; }
        public long SoloShowdownVictories { get; set; }
        public long DuoShowdownVictories { get; set; }
        public long TotalExp { get; set; }
        public string ExpFmt { get; set; }
        public long ExpLevel { get; set; }
        public long Trophies { get; set; }
        public long HighestTrophies { get; set; }
        public long AvatarId { get; set; }
        public Uri AvatarUrl { get; set; }
        public string BestTimeAsBigBrawler { get; set; }
        public string BestRoboRumbleTime { get; set; }
        public bool HasSkins { get; set; }
        public List<Brawler> Brawlers { get; set; }
    }

    public class Id
    {
        public long High { get; set; }
        public long Low { get; set; }
    }
}
