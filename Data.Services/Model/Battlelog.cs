using System;
using System.Collections.Generic;

namespace Data.Services.Model
{
    public class Battlelog
    {
        public List<Item> Items { get; set; }

        public Paging Paging { get; set; }       
        
        public enum Mode
        {
            BigGame,
            BossFight,
            BrawlBall,
            Bounty,
            DuoShowdown,
            GemGrab,
            Heist,
            LoneStar,
            RoboRumble,
            Siege,
            SoloShowdown,
            Takedown
        }

        public enum Result
        {
            Defeat,
            Draw,
            Victory
        }

        public enum TypeEnum
        {
            Friendly,
            Ranked
        }
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
