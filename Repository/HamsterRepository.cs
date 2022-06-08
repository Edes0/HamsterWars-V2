using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Shared.RequestFeatures;

namespace Repository
{
    public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
    {
        public HamsterRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Hamster>> GetAllHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges)
        {
            var hamsters = await FindByCondition(h => h.Age >= hamsterParameters.MinAge && h.Age <= hamsterParameters.MaxAge, trackChanges)
                .FilterHamsters(hamsterParameters.MinAge, hamsterParameters.MaxAge)
                .Search(hamsterParameters.SearchTerm)
                .Sort(hamsterParameters.OrderBy)
                .ToListAsync();

            return PagedList<Hamster>
            .ToPagedList(hamsters, hamsterParameters.PageNumber, hamsterParameters.PageSize);
        }

        public async Task<Hamster> GetHamsterAsync(Guid hamsterId, bool trackChanges) =>
         await FindByCondition(c => c.Id.Equals(hamsterId), trackChanges)
         .SingleOrDefaultAsync();

        public void CreateHamster(Hamster hamster) => Create(hamster);

        public async Task<IEnumerable<Hamster>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
         await FindByCondition(x => ids.Contains(x.Id), trackChanges)
         .ToListAsync();

        public void DeleteHamster(Hamster hamster) => Delete(hamster);
    }


}
