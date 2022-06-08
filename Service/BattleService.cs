using AutoMapper;
using Contracts;
using Entities.Models;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service
{
    internal sealed class BattleService : IBattleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public BattleService(IRepositoryManager repository, ILoggerManager logger,
        IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<BattleDto>> GetAllBattlesAsync(BattleParameters battleParameters, bool trackChanges)
        {
            if (!battleParameters.ValidDateRange)
                throw new MaxDateRangeBadRequestException();

            var battles = await _repository.Battle.GetAllBattlesAsync(battleParameters, trackChanges);
            var battlesDto = _mapper.Map<IEnumerable<BattleDto>>(battles);
            return battlesDto;
        }
        public async Task<BattleDto> GetBattleAsync(Guid id, bool trackChanges)
        {
            var battle = await GetBattleAndCheckIfItExists(id, trackChanges);

            var battleDto = _mapper.Map<BattleDto>(battle);
            return battleDto;
        }
        public async Task<BattleDto> CreateBattleAsync(BattleForCreationDto battle)
        {
            var battleEntity = _mapper.Map<Battle>(battle);
            _repository.Battle.CreateBattle(battleEntity);
            await _repository.SaveAsync();
            var battleToReturn = _mapper.Map<BattleDto>(battleEntity);
            return battleToReturn;
        }

        public async Task<IEnumerable<BattleDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var battleEntities = await _repository.Battle.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != battleEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var battlesToReturn = _mapper.Map<IEnumerable<BattleDto>>(battleEntities);
            return battlesToReturn;
        }

        public async Task<(IEnumerable<BattleDto> battles, string ids)> CreateBattleCollectionAsync(IEnumerable<BattleForCreationDto> battleCollection)
        {
            if (battleCollection is null)
                throw new BattleCollectionBadRequest();

            var battleEntities = _mapper.Map<IEnumerable<Battle>>(battleCollection);

            foreach (var battle in battleEntities)
            {
                _repository.Battle.CreateBattle(battle);
            }

            await _repository.SaveAsync();
            var battleCollectionToReturn = _mapper.Map<IEnumerable<BattleDto>>(battleEntities);
            var ids = string.Join(",", battleCollectionToReturn.Select(c => c.Id));
            return (battles: battleCollectionToReturn, ids: ids);
        }

        public async Task DeleteBattleAsync(Guid battleId, bool trackChanges)
        {
            var battle = await GetBattleAndCheckIfItExists(battleId, trackChanges);

            _repository.Battle.DeleteBattle(battle);
            await _repository.SaveAsync();
        }

        public async Task UpdateBattleAsync(Guid battleId, BattleForUpdateDto battleForUpdate, bool trackChanges)
        {
            var battle = await GetBattleAndCheckIfItExists(battleId, trackChanges);

            _mapper.Map(battleForUpdate, battle);
            await _repository.SaveAsync();
        }

        private async Task<Battle> GetBattleAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var battle = await _repository.Battle.GetBattleAsync(id, trackChanges);

            if (battle is null)
                throw new BattleNotFoundException(id);

            return battle;
        }

        public async Task<IEnumerable<BattleDto>> GetMatchWinnersAsync(Guid hamsterId, BattleParameters battleParameters, bool trackChanges)
        {
            if (!battleParameters.ValidDateRange)
                throw new MaxDateRangeBadRequestException();

            battleParameters.HamsterId = hamsterId.ToString();
            var battles = await _repository.Battle.GetAllBattlesAsync(battleParameters, trackChanges);

            if (battles is null)
                throw new BattlesForHamsterNotFoundException(hamsterId);

            var battlesDto = _mapper.Map<IEnumerable<BattleDto>>(battles);
            return battlesDto;
        }
    }
}
