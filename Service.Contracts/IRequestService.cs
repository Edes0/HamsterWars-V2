using Entities.Models;

namespace Service.Contracts
{
    public interface IRequestService
    {
        Task<List<Hamster>> GetHamsters();
        Task<Hamster> GetRandomHamster();
        Task<(Hamster, Hamster)> GetTwoRandomUniqueHamsters();
        Task PostBattle(Hamster winner, Hamster loser);
        Task UpdateLoser(Hamster loser);
        Task UpdateWinner(Hamster winner);
        Task PostHamster(Hamster newHamster);
        Task DeleteHamster(Hamster hamster);
        Task<List<Battle>> GetBattles();
        Task<List<Battle>> GetWonBattles(Hamster hamster);
        Task DeleteBattle(Battle battle);
        Task<List<Hamster>> GetLoserHamsters();
        Task<List<Hamster>> GetWinnerHamsters();
    }
}
