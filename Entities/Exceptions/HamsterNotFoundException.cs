namespace Entities.Exceptions
{
    public class HamsterNotFoundException : NotFoundException
    {
        public HamsterNotFoundException(Guid hamsterId)
        : base($"Hamster with id: {hamsterId} doesn't exist in the database.")
        {
        }
    }

}
