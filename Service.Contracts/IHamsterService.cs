using Entities.Models;
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
        Task UpdateHamsterAsync(Guid hamsterid, HamsterForUpdateDto hamsterForUpdate, bool trackChanges);
        Task<HamsterDto> GetRandomHamsterAsync(HamsterParameters hamsterParameters, bool trackChanges);
        Task<IEnumerable<HamsterDto>> GetWinnerHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges);
        Task<IEnumerable<HamsterDto>> GetLoserHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges);
    }
}
