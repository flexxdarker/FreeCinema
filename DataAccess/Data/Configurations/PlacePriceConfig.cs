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
    public class PlacePriceConfig : IEntityTypeConfiguration<PP>
    {
        public void Configure(EntityTypeBuilder<PP> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Session).WithMany(x => x.PlacePrices).HasForeignKey(x => x.SessionId);
            builder.HasOne(x => x.Place).WithMany(x => x.PlacePrices).HasForeignKey(x => x.PlaceId);
        }
    }
}
