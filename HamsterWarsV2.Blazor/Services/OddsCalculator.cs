namespace HamsterWars.Services
{
    public static class OddsCalculator
    {
        public static int Calculate(int winnerWinrate, int loserWinrate)
        {

            decimal oddsDec = (decimal)winnerWinrate / ((decimal)winnerWinrate + (decimal)loserWinrate) * 100;

            return (int)oddsDec; ;
        }
    }
}
