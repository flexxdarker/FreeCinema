using Ardalis.Specification;
using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Specifications
{
    public class ReservationSpecs
    {
        internal class ByIds: Specification<Reservation>
        {
            public ByIds(IEnumerable<int> ids) 
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x=>x.PlacePrices);
            }
        }
        internal class ByUser: Specification<Reservation>
        {
            public ByUser(string userId)
            {
                Query
                    .Where(x => x.UserId == userId)
                    .Include(x => x.Session);
            }
        }
    }
}
