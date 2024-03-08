using Ardalis.Specification;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic.Specifications
{
    public static class FilmSpecs
    {
        internal class ById : Specification<Film>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Category);
            }
        }
        internal class All : Specification<Film>
        {
            public All()
            {
                Query.Include(x => x.Category);
            }
        }
        internal class ByIds : Specification<Film>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Category);
            }
        }
    }
}
