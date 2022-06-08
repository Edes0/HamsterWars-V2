using Entities.Models;
using Service.Contracts;
using System.Net.Http.Json;

namespace Service
{
    // TODO: FIX THIS
    public class RequestService : IRequestService
    {
        private readonly HttpClient _httpClient;

        public RequestService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<List<Hamster>> GetHamsters()
        {
            var hamsters = await _httpClient.GetFromJsonAsync<List<Hamster>>("/api/hamsters");

            var activeHamsters = from hamster in hamsters
                                 where hamster.Status == "Active"
                                 select hamster;

            return activeHamsters.ToList();
        }

        public async Task<List<Battle>> GetWonBattles(Hamster hamster)
        {
            var battles = await _httpClient.GetFromJsonAsync<List<Battle>>($"/api/battles/matchWinners/{hamster.Id}");

            return battles;
        }

        public async Task<List<Hamster>> GetWinnerHamsters()
        {
            var hamsters = await _httpClient.GetFromJsonAsync<List<Hamster>>($"/api/hamsters/winners");

            return hamsters;
        }

        public async Task<List<Hamster>> GetLoserHamsters()
        {
            var hamsters = await _httpClient.GetFromJsonAsync<List<Hamster>>($"/api/hamsters/losers");

            return hamsters;
        }

        public async Task DeleteBattle(Battle battle)
        {
            await _httpClient.DeleteAsync($"/api/battles/{battle.Id}");
        }
        

        public async Task DeleteHamster(Hamster hamster)
        {
            await _httpClient.DeleteAsync($"/api/hamsters/{hamster.Id}");
        }

        public async Task<List<Battle>> GetBattles()
        {
            var battles = await _httpClient.GetFromJsonAsync<List<Battle>>("/api/battles");

            return battles;
        }

        public async Task PostBattle(Hamster winner, Hamster loser)
        {
            Battle battle = new Battle(winner.Id, loser.Id);

            await _httpClient.PostAsJsonAsync<Battle>("/api/battles", battle);
        }

        public async Task PostHamster(Hamster newHamster)
        {
            await _httpClient.PostAsJsonAsync("/api/hamsters", newHamster);
        }

        public async Task UpdateWinner(Hamster winner)
        {
            winner.Games++;
            winner.Wins++;

            await _httpClient.PutAsJsonAsync($"/api/hamsters/{winner.Id}", winner);
        }

        public async Task UpdateLoser(Hamster loser)
        {
            loser.Games++;
            loser.Wins++;

            await _httpClient.PutAsJsonAsync($"/api/hamsters/{loser.Id}", loser);
        }

        public async Task<Hamster> GetRandomHamster()
        {
            var hamster = await _httpClient.GetFromJsonAsync<Hamster>("/api/hamsters/random");

            return hamster;
        }

        public async Task<(Hamster, Hamster)> GetTwoRandomUniqueHamsters()
        {
            var hamster1 = await GetRandomHamster();
            var hamster2 = await GetRandomHamster();

            while (hamster1.Id == hamster2.Id)
            {
                hamster2 = await GetRandomHamster();
            }

            return (hamster1, hamster2);
        }
    }
}
