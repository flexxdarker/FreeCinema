using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Configurations
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        void IEntityTypeConfiguration<Session>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.ToTable("Sessions");
        }
    }
}
