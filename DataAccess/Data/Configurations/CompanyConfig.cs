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
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        void IEntityTypeConfiguration<Company>.Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.ToTable("Companies");
        }
    }
}
