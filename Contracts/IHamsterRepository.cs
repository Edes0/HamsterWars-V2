using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> GetAllHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges);
        Task<Hamster> GetHamsterAsync(Guid hamsterId, bool trackChanges);
        void CreateHamster(Hamster hamster);
        Task<IEnumerable<Hamster>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteHamster(Hamster hamster);
    }
}
