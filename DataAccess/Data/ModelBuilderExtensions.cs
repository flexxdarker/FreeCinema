using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Film>().HasData(new[]
            {
                new Film() { Id = 1, Company = "Universal Picture", Year = 2001, Name = "Fast&Furious 1"},
                new Film() { Id = 2, Company = "Universal Picture", Year = 2003, Name = "Fast&Furious 2"},
            });
        }
    }
}
