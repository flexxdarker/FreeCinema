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
        public int Cinema_HallId { get; set; }
        public Cinema_Hall? Hall { get; set; }
    }
}
