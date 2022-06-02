using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace Repository.Extensions
{
    public static class RepositoryBattleExtensions
    {
        public static IQueryable<Battle> FilterBattles(this IQueryable<Battle> battles, DateTime minDate, DateTime maxDate) =>
        battles.Where(b => b.Date >= minDate && b.Date <= maxDate);

        public static IQueryable<Battle> Search(this IQueryable<Battle> battles, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return battles;

            return battles;
        }

        public static IQueryable<Battle> Sort(this IQueryable<Battle> battles, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return battles.OrderBy(e => e.Date);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Battle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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
                return battles.OrderBy(e => e.Date);

            return battles.OrderBy(orderQuery);
        }
    }
}
