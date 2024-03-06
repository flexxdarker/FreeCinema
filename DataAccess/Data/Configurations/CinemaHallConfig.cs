using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Configurations
{
    public class CinemaHallConfig : IEntityTypeConfiguration<CinemaHall>
    {
        void IEntityTypeConfiguration<CinemaHall>.Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Places).WithOne(x => x.CinemaHall).HasForeignKey(x => x.CinemaHallId);
            //builder.ToTable("CinemaHalls");
        }
    }
}
