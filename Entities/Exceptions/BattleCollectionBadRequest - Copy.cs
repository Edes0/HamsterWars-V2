
namespace Entities.Exceptions
{
    public sealed class BattleCollectionBadRequest : BadRequestException
    {
        public BattleCollectionBadRequest()
        : base("Battle collection sent from a client is null.")
        {
        }
    }
}
