
namespace Entities.Exceptions
{
    public sealed class BattlesForHamsterNotFoundException : NotFoundException
    {
        public BattlesForHamsterNotFoundException(Guid hamsterId)
        : base($"battles for hamster with id: {hamsterId} doesn't exist in the database.")
        {
        }
    }
}