using Data.Services.Model;
using Data.Services.Serialization;
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
            return JsonConvert.DeserializeObject<Battlelog>(response, SerializerSettings.JsonSerializerSettings);
        }
    }
}
