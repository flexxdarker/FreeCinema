using Ardalis.Specification;
using BusinessLogic.Entities;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic.Specifications
{
    internal class CompanySpecs
    {
        internal class All : Specification<Company>
        {
            public All()
            {
                Query.Include(x => x.Films);
            }
        }
        internal class ByIds : Specification<Company>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Films);
            }
        }
    }
}
