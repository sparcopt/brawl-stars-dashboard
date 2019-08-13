using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentation.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient client;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brawlapi.cf/v1");
            var client = httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkaXNjb3JkX3VzZXJfaWQiOiIxNTA2NTUyMjExMDQ3NzEwNzQiLCJyZWFzb24iOiJUZWFtIERhc2hib2FyZCIsInZlcnNpb24iOjEsImlhdCI6MTU2NTAzOTIyOX0.5cMGUgTYKKVQTQCfdrPjEL36CB8L6ItGeXFXGLlrF58");
            this.client = client;
        }

        public async Task<IActionResult> Index()
        {
            var player = await GetPlayerAsync("9QQJJGQYQ");
            var club = await GetClubAsync("PJP8LOJV");
            //var battlelog = await GetPlayerBattlelog("9QQJJGQYQ");

            var playerTags = new string[] { "9QQJJGQYQ", "9YLQ02RY2", "922V0UP9R", "9982GULG2", "P8C90QC99", "P8VJC8UUR", "2C8VLPYJQ", "9QJ9YLPUU" };

            var battles = new List<Item>();

            foreach(var tag in playerTags)
            {
                var playerBattlelog = await GetPlayerBattlelog(tag);
                battles.AddRange(playerBattlelog.Items);
            }

            var model = new HomeModel
            {
                Club = club,
                BattleLogItems = battles
                    .Where(b => b.Battle.Mode == Battlelog.Mode.GemGrab)
                    .OrderByDescending(b => b.BattleTime).Take(4)
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<Player> GetPlayerAsync(string playerTag)
        {
            var response = await client.GetAsync($"https://brawlapi.cf/v1/player?tag={playerTag}");
            return await response.Content.ReadAsAsync<Player>();
        }

        private async Task<Club> GetClubAsync(string clubTag)
        {
            var response = await client.GetAsync($"https://brawlapi.cf/v1/club?tag={clubTag}");
            return await response.Content.ReadAsAsync<Club>();
        }

        private async Task<Battlelog> GetPlayerBattlelog(string playerTag)
        {
            var response = await client.GetAsync($"https://brawlapi.cf/v1/player/battlelog?tag={playerTag}");
            var content = await response.Content.ReadAsStringAsync();

            var set = new JsonSerializerSettings // check why I can't set this at start
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateFormatString = "yyyyMMddTHHmmss.fffZ",
            };

            return JsonConvert.DeserializeObject<Battlelog>(content, set);
        }
    }
}
