namespace HamsterWars.Services
{
    public static class PercentageCalculator
    {
        public static int Calculate(int wins, int games)
        {
            if (games == 0) return 0;

            decimal number = (decimal)wins / (decimal)games;
            number = Math.Round(number * 100);

            return (int)number;
        }
    }
}
