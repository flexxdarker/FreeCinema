using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateReservationModel
    {
        public int Number { get; set; }
        public int SessionId { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<Place>? Places { get; set; }
    }
}
