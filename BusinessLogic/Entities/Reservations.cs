using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Reservations
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public Session? Session { get; set; }    
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
        public int PlacePriceId { get; set; }
        public ICollection<PlacePrice> PlacePrices { get; set; }
    }
}
