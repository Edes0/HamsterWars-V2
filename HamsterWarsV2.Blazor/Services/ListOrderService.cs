using Entities.Models;
using HamsterWars.Services;

namespace HamsterWarsV2.Blazor.Services
{
    public static class ListOrderService
    {
        public static List<Hamster> OrderHamsterByWinPercentage(List<Hamster> hamsters)
        {
            return hamsters.OrderByDescending(i => Calculator.CalculatePercentage(i.Wins, i.Games)).ToList();
        }
        public static List<Battle> OrderBattleByDate(List<Battle> battles)
        {
            return battles.OrderByDescending(b => b.Date).ToList();
        }
    }
}
