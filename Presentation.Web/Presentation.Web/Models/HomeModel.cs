using System.Collections.Generic;

namespace Presentation.Web.Models
{
    public class HomeModel
    {
        public Club Club { get; set; }
        public IEnumerable<Item> BattleLogItems { get;set; }
    }
}
