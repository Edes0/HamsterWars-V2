using Entities.Models;

namespace HamsterWarsV2.Blazor.Services
{
    public static class RemovedHamsterHelperClass
    {
        public static Hamster CheckIfHamsterExists(List<Hamster> hamsters, Guid hamsterId)
        {
            if (hamsters.Any(h => h.Id == hamsterId)) return hamsters.Where(h => h.Id == hamsterId).Single();
            return new Hamster { Name = "REMOVED" };
        }

        public static Hamster ReturnLastBattleWinner(List<Hamster> hamsters, List<Battle> battles)
        {
            if (hamsters.Any(h => h.Id == battles.Last().Winner_ID))
            { 
                return hamsters.Where(h => h.Id == battles.Last().Winner_ID).Single();
            }
            else
            {
                return new Hamster { Name = "REMOVED", ImageName = "hamster-43.jpg", Games = 1, Wins = 0 };
            }
        }

        public static Hamster ReturnLastBattleLoser(List<Hamster> hamsters, List<Battle> battles)
        {
            if (hamsters.Any(h => h.Id == battles.Last().Loser_ID))
            {
                return hamsters.Where(h => h.Id == battles.Last().Loser_ID).Single();
            }
            else
            {
                return new Hamster { Name = "REMOVED", ImageName = "hamster-43.jpg", Games = 1, Wins = 0 };
            }
        }
    }
}
