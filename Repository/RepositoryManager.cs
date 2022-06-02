using Contracts;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IBattleRepository> _battleRepository;
        private readonly Lazy<IHamsterRepository> _hamsterRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _hamsterRepository = new Lazy<IHamsterRepository>(() => new
            HamsterRepository(repositoryContext));
            _battleRepository = new Lazy<IBattleRepository>(() => new
            BattleRepository(repositoryContext));
        }
        public IHamsterRepository Hamster => _hamsterRepository.Value;
        public IBattleRepository Battle => _battleRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }

}
