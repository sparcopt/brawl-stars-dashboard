using System.Collections.Generic;
using static Data.Services.Model.Battlelog;

namespace Data.Services.Model
{
    public class Battle
    {
        public Mode Mode { get; set; }
        public TypeEnum Type { get; set; }
        public Result Result { get; set; }
        public long Duration { get; set; }
        public long TrophyChange { get; set; }
        public StarPlayer StarPlayer { get; set; }
        public List<List<StarPlayer>> Teams { get; set; }
    }
}
