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
        public static int CalculateOdds(int winnerWinrate, int loserWinrate)
        {

            decimal oddsDec = (decimal)winnerWinrate / ((decimal)winnerWinrate + (decimal)loserWinrate) * 100;

            return (int)oddsDec; ;
        }

        public static int CalculatePercentage(List<Hamster> hamsters, List<Battle> battles)
        {
            int percentage;

            (Hamster winnerHamster, Hamster loserHamster) = PercentageBarServices.GetResultHamsters(hamsters, battles);
            (int winnerWinrate, int loserWinrate) = PercentageBarServices.CalculateWinRate(winnerHamster, loserHamster);

            if (winnerWinrate > loserWinrate)
            {
                return percentage = CalculateOdds(winnerWinrate, loserWinrate);
            }
            else
            {
                percentage = CalculateOdds(loserWinrate, winnerWinrate);
                return percentage = 100 - percentage;
            }
        }
    }
}
