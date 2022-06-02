using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBattleService> _battleService;
        private readonly Lazy<IHamsterService> _hamsterService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger, IMapper mapper)
        {
            _battleService = new Lazy<IBattleService>(() =>
            new BattleService(repositoryManager, logger, mapper));
            _hamsterService = new Lazy<IHamsterService>(() =>
            new HamsterService(repositoryManager, logger, mapper));
        }
        public IBattleService BattleService => _battleService.Value;
        public IHamsterService HamsterService => _hamsterService.Value;
    }
}
