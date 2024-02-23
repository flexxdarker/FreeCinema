using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        //public DateTime Date { get; set; }
        public int Year { get; set; }
    }
}
