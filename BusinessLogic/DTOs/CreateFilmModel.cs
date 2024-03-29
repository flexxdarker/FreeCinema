﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateFilmModel
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; } //IFormFile 
    }
}
