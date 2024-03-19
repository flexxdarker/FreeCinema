using Ardalis.Specification;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Specifications
{
    public static class SessionSpecs
    {
        internal class ById : Specification<Session> 
        {
            public ById(int id) 
            {
                Query.Where(x=>x.Id == id)
                    .Include(x=>x.CinemaHall)
                    .Include(x=>x.Film);
            }

        }
        internal class All : Specification<Session>
        {
            public All()
            {
                Query.Where(x => x.DateTime.Date > DateTime.Now)
                    .Include(x => x.CinemaHall)
                    .Include(x => x.Film);
            }
        }
        internal class ByIds : Specification<Session>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query.Where(x => ids.Contains(x.Id))
                    .Include(x => x.CinemaHall)
                    .Include(x => x.Film);
            }
        }
    }
}
