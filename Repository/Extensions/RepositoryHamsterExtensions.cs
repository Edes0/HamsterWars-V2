using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace Repository.Extensions
{
    public static class RepositoryHamsterExtensions
    {
        public static IQueryable<Hamster> FilterHamsters(this IQueryable<Hamster> hamsters, uint minAge, uint maxAge) =>
        hamsters.Where(e => (e.Age >= minAge && e.Age <= maxAge));

        public static IQueryable<Hamster> Search(this IQueryable<Hamster> hamsters, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return hamsters;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return hamsters.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Hamster> Sort(this IQueryable<Hamster> hamsters, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return hamsters.OrderBy(e => e.Name);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Hamster).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi =>
               pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {direction},");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
                return hamsters.OrderBy(e => e.Name);

            return hamsters.OrderBy(orderQuery);
        }
        public static IQueryable<Hamster> GetOnlyActive(this IQueryable<Hamster> hamsters)
        {
            return hamsters.Where(h => h.Status == "Active");
        }
    }
}
