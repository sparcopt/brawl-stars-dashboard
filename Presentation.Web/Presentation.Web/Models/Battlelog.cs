using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Presentation.Web.Models
{
    public class Battlelog
    {
        public List<Item> Items { get; set; }
        public Paging Paging { get; set; }           
        public enum Mode { BrawlBall, Bounty, DuoShowdown, GemGrab, Heist, Siege };
        public enum Result { Defeat, Draw, Victory };
        public enum TypeEnum { Ranked };
        public enum Map
        {
            [EnumMember(Value = "Beach Ball")]
            BeachBall,
            [EnumMember(Value = "Feast or Famine")]
            FeastOrFamine,
            [EnumMember(Value = "Four Squared")]
            FourSquared,
            [EnumMember(Value = "Hard Rock Mine")]
            HardRockMine,
            [EnumMember(Value = "Junk Park")]
            JunkPark,
            [EnumMember(Value = "Minecart Madness")]
            MinecartMadness,
            [EnumMember(Value = "Thousand Lakes")]
            ThousandLakes,
            [EnumMember(Value = "Sandy Gems")]
            SandyGems,
            [EnumMember(Value = "Sunstroke")]
            Sunstroke,
            [EnumMember(Value = "Snake Prairie")]
            SnakePrairie
        };
    }

    public class Paging
    {
        public Cursors Cursors { get; set; }
    }

    public class Cursors
    {
    }

    public class Item
    {
        public DateTime BattleTime { get; set; }
        public Event Event { get; set; }
        public Battle Battle { get; set; }
    }
}
