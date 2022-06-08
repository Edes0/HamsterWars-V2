using Entities.Models;

namespace HamsterWarsV2.Blazor.Services
{
    public static class PercentageBarServices
    {
        public static (Hamster, Hamster) GetResultHamsters(List<Hamster> hamsters, List<Battle> battles)
        {
            Hamster winnerHamster = RemovedHamsterHelperClass.ReturnLastBattleWinner(hamsters, battles);
            Hamster loserHamster = RemovedHamsterHelperClass.ReturnLastBattleLoser(hamsters, battles);

            return (winnerHamster, loserHamster);
        }
        public static (int, int) CalculateWinRate(Hamster winnerHamster, Hamster loserHamster)
        {
            decimal winnerHamsterWinRate = (decimal)winnerHamster.Wins / (decimal)winnerHamster.Games;
            winnerHamsterWinRate = Math.Round(winnerHamsterWinRate * 100);

            decimal loserHamsterWinRate = (decimal)loserHamster.Wins / (decimal)loserHamster.Games;
            loserHamsterWinRate = Math.Round(loserHamsterWinRate * 100);

            return ((int)winnerHamsterWinRate, (int)loserHamsterWinRate);
        }
    }
}
