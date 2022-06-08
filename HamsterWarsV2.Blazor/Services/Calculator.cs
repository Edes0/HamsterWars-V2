namespace HamsterWars.Services
{
    public static class Calculator
    {
        public static int CalculatePercentage(int wins, int games)
        {
            if (games == 0) return 0;

            decimal number = (decimal)wins / (decimal)games;
            number = Math.Round(number * 100);

            return (int)number;
        }
    }
}
