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
    }
}
