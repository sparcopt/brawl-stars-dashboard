using Data.Services.Model;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface IBrawlStarsService
    {
        Task<Player> GetPlayerAsync(string playerTag);
        Task<Club> GetClubAsync(string clubTag);
        Task<Battlelog> GetPlayerBattlelog(string playerTag);
    }
}
