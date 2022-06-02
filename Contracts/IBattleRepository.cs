using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IBattleRepository
    {
        Task<IEnumerable<Battle>> GetAllBattlesAsync(BattleParameters battleParameters, bool trackChanges);
        Task<Battle> GetBattleAsync(Guid battleId, bool trackChanges);
        void CreateBattle(Battle battle);
        Task<IEnumerable<Battle>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteBattle(Battle battle);
    }
}
