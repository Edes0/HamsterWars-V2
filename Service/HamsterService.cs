using AutoMapper;
using Contracts;
using Entities.Models;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service
{
    internal sealed class HamsterService : IHamsterService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public HamsterService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(HamsterParameters hamsterParameters, bool trackChanges)
        {
            if (!hamsterParameters.ValidAgeRange)
                throw new MaxAgeRangeBadRequestException();

            var hamsters = await _repository.Hamster.GetAllHamstersAsync(hamsterParameters, trackChanges);
            var hamstersDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);
            return hamstersDto;
        }
        public async Task<HamsterDto> GetHamsterAsync(Guid id, bool trackChanges)
        {
            var hamster = await GetHamsterAndCheckIfItExists(id, trackChanges);

            var hamsterDto = _mapper.Map<HamsterDto>(hamster);
            return hamsterDto;
        }
        public async Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster)
        {
            var hamsterEntity = _mapper.Map<Hamster>(hamster);
            _repository.Hamster.CreateHamster(hamsterEntity);
            await _repository.SaveAsync();
            var hamsterToReturn = _mapper.Map<HamsterDto>(hamsterEntity);
            return hamsterToReturn;
        }

        public async Task<IEnumerable<HamsterDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var hamsterEntities = await _repository.Hamster.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != hamsterEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var hamsterToReturn = _mapper.Map<IEnumerable<HamsterDto>>(hamsterEntities);
            return hamsterToReturn;
        }

        public async Task<(IEnumerable<HamsterDto> hamsters, string ids)> CreateHamsterCollectionAsync(IEnumerable<HamsterForCreationDto> hamsterCollection)
        {
            if (hamsterCollection is null)
                throw new HamsterCollectionBadRequest();

            var hamsterEntities = _mapper.Map<IEnumerable<Hamster>>(hamsterCollection);

            foreach (var hamster in hamsterEntities)
            {
                _repository.Hamster.CreateHamster(hamster);
            }

            await _repository.SaveAsync();
            var hamsterCollectionToReturn = _mapper.Map<IEnumerable<HamsterDto>>(hamsterEntities);
            var ids = string.Join(",", hamsterCollectionToReturn.Select(c => c.Id));

            return (hamster: hamsterCollectionToReturn, ids: ids);
        }

        public async Task DeleteHamsterAsync(Guid hamsterId, bool trackChanges)
        {
            var hamster = await GetHamsterAndCheckIfItExists(hamsterId, trackChanges);

            _repository.Hamster.DeleteHamster(hamster);
            await _repository.SaveAsync();
        }

        public async Task UpdateHamsterAsync(Guid hamsterId, HamsterForUpdateDto hamsterForUpdate, bool trackChanges)
        {
            var hamster = await GetHamsterAndCheckIfItExists(hamsterId, trackChanges);

            _mapper.Map(hamsterForUpdate, hamster);
            await _repository.SaveAsync();
        }
        private async Task<Hamster> GetHamsterAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var hamster = await _repository.Hamster.GetHamsterAsync(id, trackChanges);

            if (hamster is null)
                throw new HamsterNotFoundException(id);

            return hamster;
        }
    }
}
