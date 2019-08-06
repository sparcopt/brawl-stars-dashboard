using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Web.Models
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
        //public Club Club { get; set; }
        public List<Brawler> Brawlers { get; set; }
    }

    public class Brawler
    {
        public string Name { get; set; }
        public bool HasSkin { get; set; }
        public object Skin { get; set; }
        public long Trophies { get; set; }
        public long HighestTrophies { get; set; }
        public long Power { get; set; }
        public long Rank { get; set; }
    }

    //public class Club
    //{
    //    public Id Id { get; set; }
    //    public string Tag { get; set; }
    //    public string Name { get; set; }
    //    public string Role { get; set; }
    //    public long BadgeId { get; set; }
    //    public Uri BadgeUrl { get; set; }
    //    public long Members { get; set; }
    //    public long Trophies { get; set; }
    //    public long RequiredTrophies { get; set; }
    //    public long OnlineMembers { get; set; }
    //}

    public class Id
    {
        public long High { get; set; }
        public long Low { get; set; }
    }
}
