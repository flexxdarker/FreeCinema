using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public enum Categories
    {
        Action = 1,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Mystery,
        Romance,
        Thriller,
        Other
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Film>? films { get; set; }
    } 
}
