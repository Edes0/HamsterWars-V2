using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IBattleService
    {
        Task<IEnumerable<BattleDto>> GetAllBattlesAsync(BattleParameters battleParameters, bool trackChanges);
        Task<BattleDto> GetBattleAsync(Guid battleId, bool trackChanges);
        Task<BattleDto> CreateBattleAsync(BattleForCreationDto battle);
        Task<IEnumerable<BattleDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool
        trackChanges);
        Task<(IEnumerable<BattleDto> battles, string ids)> CreateBattleCollectionAsync(IEnumerable<BattleForCreationDto> battleCollection);
        Task DeleteBattleAsync(Guid battleId, bool trackChanges);
        Task UpdateBattleAsync(Guid battleId, BattleForUpdateDto battleForUpdate, bool trackChanges);
        Task<IEnumerable<BattleDto>> GetMatchWinnersAsync(Guid battleId, BattleParameters battleParameters, bool trackChanges);
    }
}
