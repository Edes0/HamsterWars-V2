
namespace Contracts
{
    public interface IRepositoryManager
    {
        IBattleRepository Battle { get; }
        IHamsterRepository Hamster { get; }
        Task SaveAsync();
    }
}
