using Entities.Domain.Models;

namespace Contracts
{
    namespace Contracts
    {
        public interface ICompanyRepository
        {
            IEnumerable<Company> GetAllCompanies(bool trackChanges);
            Company GetCompany(Guid companyId, bool trackChanges);

        }
    }

}
