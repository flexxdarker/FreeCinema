using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateSessionModel
    {
        public DateOnly Date { get; set; }
        public int FilmId { get; set; }
        public int CinemaHallId { get; set; }
    }
}
