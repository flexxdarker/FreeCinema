using Ardalis.Specification;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Specifications
{
    public class PPSpecs
    {
        internal class ById: Specification<PP>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x=>x.Place)
                    .Include(x=>x.Session);
            }
        }
    }
}
