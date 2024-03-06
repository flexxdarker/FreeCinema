using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CinemaHallId { get; set; }
        public CinemaHall? CinemaHall { get; set; }
    }
}
