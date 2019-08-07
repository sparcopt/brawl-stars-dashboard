namespace Presentation.Web.Models
{
    public class Brawler
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasSkin { get; set; }
        public object Skin { get; set; }
        public long Power { get; set; }
        public long Trophies { get; set; }
        public long HighestTrophies { get; set; }
        public long Rank { get; set; }
    }
}
