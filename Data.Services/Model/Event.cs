using static Data.Services.Model.Battlelog;

namespace Data.Services.Model
{
    public class Event
    {
        public long Id { get; set; }
        public Mode Mode { get; set; }
        public string Map { get; set; }
    }
}
