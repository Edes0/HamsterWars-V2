using Entities.Models;

namespace Service
{
    public static class Randomizer
    {
        public static Hamster GetRandomHamsterFromList(List<Hamster> hamsters)
        {
            Random random = new();

            Hamster hamster = hamsters[random.Next(0, hamsters.Count)];

            return hamster;
        }
    }
}
