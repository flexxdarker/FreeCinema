using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int FilmId { get; set; }
        public Film? Film { get; set; }
        public int CinemaHallId { get; set; }
        public CinemaHall? CinemaHall { get; set; }
        public ICollection<PP> PlacePrices { get; set; }
    }
}
