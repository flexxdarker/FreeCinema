using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateFilmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int Year { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
