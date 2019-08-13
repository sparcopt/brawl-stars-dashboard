using Data.Services.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Data.Services
{
    public class BrawlStarsService : IBrawlStarsService
    {
        private readonly HttpClient httpClient;

        public BrawlStarsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Club> GetClubAsync(string clubTag)
        {
            var response = await httpClient.GetStringAsync($"club?tag={clubTag}");
            return JsonConvert.DeserializeObject<Club>(response);
        }

        public async Task<Player> GetPlayerAsync(string playerTag)
        {
            var response = await httpClient.GetStringAsync($"player?tag={playerTag}");
            return JsonConvert.DeserializeObject<Player>(response);
        }

        public async Task<Battlelog> GetPlayerBattlelog(string playerTag)
        {
            var response = await httpClient.GetStringAsync($"player/battlelog?tag={playerTag}");

            var set = new JsonSerializerSettings // move this
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateFormatString = "yyyyMMddTHHmmss.fffZ",
            };

            return JsonConvert.DeserializeObject<Battlelog>(response, set);
        }
    }
}
