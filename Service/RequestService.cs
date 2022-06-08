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

            return hamsters;
        }

        public async Task PostBattle(Hamster winner, Hamster loser)
        {
            Battle battle = new Battle(winner.Id, loser.Id);

            await _httpClient.PostAsJsonAsync<Battle>("/api/battles", battle);

        }

        public async Task UpdateWinner(Hamster winner)
        {
            await _httpClient.PutAsJsonAsync($"/api/hamsters/updatewinner/{winner.Id}", winner);
        }

        public async Task UpdateLoser(Hamster loser)
        {
            await _httpClient.PutAsJsonAsync($"/api/hamsters/updateloser/{loser.Id}", loser);
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
