
namespace Entities.Exceptions
{
    public sealed class HamsterCollectionBadRequest : BadRequestException
    {
        public HamsterCollectionBadRequest()
        : base("Hamster collection sent from a client is null.")
        {
        }
    }
}
