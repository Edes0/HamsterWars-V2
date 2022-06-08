using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Shared.RequestFeatures;

namespace Repository
{
    public class BattleRepository : RepositoryBase<Battle>, IBattleRepository
    {
        public BattleRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Battle>> GetAllBattlesAsync(BattleParameters battleParameters, bool trackChanges)
        {
            var battles = await FindByCondition(b => b.Date >= battleParameters.MinDate && b.Date <= battleParameters.MaxDate, trackChanges)
                .FilterBattles(battleParameters.MinDate, battleParameters.MaxDate)
                .Search(battleParameters.SearchTerm)
                .Sort(battleParameters.OrderBy)
                .GetWinnerBattles(battleParameters.HamsterId)
                .ToListAsync();

            return PagedList<Battle>
            .ToPagedList(battles, battleParameters.PageNumber, battleParameters.PageSize);
        }

        public async Task<Battle> GetBattleAsync(Guid battleId, bool trackChanges) =>
         await FindByCondition(c => c.Id.Equals(battleId), trackChanges)
         .SingleOrDefaultAsync();

        public void CreateBattle(Battle battle) => Create(battle);

        public async Task<IEnumerable<Battle>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
         await FindByCondition(x => ids.Contains(x.Id), trackChanges)
         .ToListAsync();

        public void DeleteBattle(Battle battle) => Delete(battle);
    }
}
