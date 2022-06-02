using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IHamsterService
    {
        Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges);
        Task<HamsterDto> GetHamsterAsync(Guid hamsterId, bool trackChanges);
        Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster);
        Task<IEnumerable<HamsterDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool
        trackChanges);
        Task<(IEnumerable<HamsterDto> hamsters, string ids)> CreateHamsterCollectionAsync(IEnumerable<HamsterForCreationDto> hamsterCollection);
        Task DeleteHamsterAsync(Guid hamsterId, bool trackChanges);
        Task UpdateHamsterAsync(Guid hamsterid, HamsterForUpdateDto hamsterForUpdate,
        bool trackChanges);
    }
}
