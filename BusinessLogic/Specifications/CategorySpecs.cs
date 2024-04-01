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
    public class CategorySpecs
    {
        internal class All : Specification<Category>
        {
            public All()
            {
                Query.Include(x => x.Films);    
            }
        }
    }
}
