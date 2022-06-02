
namespace Service.Contracts
{
    public interface IServiceManager
    {
        IBattleService BattleService { get; }
        IHamsterService HamsterService { get; }
    }
}
