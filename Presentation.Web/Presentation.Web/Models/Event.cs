using static Presentation.Web.Models.Battlelog;

namespace Presentation.Web.Models
{
    public class Event
    {
        public long Id { get; set; }
        public Mode Mode { get; set; }
        public string Map { get; set; }
    }
}
