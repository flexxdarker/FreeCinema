using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Configurations
{
	public class FilmConfig : IEntityTypeConfiguration<Film>
	{
		public void Configure(EntityTypeBuilder<Film> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x=>x.Company).WithMany(x=>x.Films).HasForeignKey(x=>x.CompanyId);
			builder.HasOne(x => x.Category).WithMany(x => x.Films).HasForeignKey(x => x.CategoryId);
			builder.HasMany(x=>x.Sessions).WithOne(x=>x.Film).HasForeignKey(x=>x.FilmId);
			//builder.ToTable("Films");
		}
	}
}
