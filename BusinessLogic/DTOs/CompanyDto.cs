using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CompanyDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }
        public IEnumerable<Film>? Films { get; set; }
    }
}
