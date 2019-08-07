using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Presentation.Web.Models
{
    public class Battlelog
    {
        public List<Item> Items { get; set; }
        public Paging Paging { get; set; }           
        public enum Mode { GemGrab };
        public enum Result { Defeat, Victory };
        public enum TypeEnum { Ranked };
        public enum Map
        {
            [EnumMember(Value = "Hard Rock Mine")]
            HardRockMine,
            [EnumMember(Value = "Minecart Madness")]
            MinecartMadness
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
        public string BattleTime { get; set; }
        public Event Event { get; set; }
        public Battle Battle { get; set; }
    }
}
