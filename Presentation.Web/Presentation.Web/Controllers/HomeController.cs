using Data.Services;
using Data.Services.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrawlStarsService brawlStarsService;
        private readonly IConfiguration configuration;

        public HomeController(IBrawlStarsService brawlStarsService, IConfiguration configuration)
        {
            this.brawlStarsService = brawlStarsService;
            this.configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var club = await brawlStarsService.GetClubAsync(configuration["ClubTag"]);

            var battles = new List<Item>();

            foreach (var player in club.Members)
            {
                var playerBattlelog = await brawlStarsService.GetPlayerBattlelog(player.Tag);
                battles.AddRange(playerBattlelog.Items);
            }

            var model = new HomeModel
            {
                Club = club,
                BattleLogItems = battles
                    .Where(b => b.Battle.Mode == Battlelog.Mode.GemGrab)
                    .OrderByDescending(b => b.BattleTime)
                    .Take(configuration.GetValue<int>("MaxNumberOfBattles"))
            };

            model.Club.Members = model.Club.Members.Take(configuration.GetValue<int>("MaxNumberOfPlayers"));

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
