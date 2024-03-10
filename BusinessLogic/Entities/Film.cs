using BusinessLogic.Entities;
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
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<CinemaHall> CinemaHalls { get; set; }
    }
}
