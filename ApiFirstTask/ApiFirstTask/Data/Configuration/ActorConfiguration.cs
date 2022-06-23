using ApiFirstTask.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFirstTask.Data.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(255);
            builder.Property(a => a.ImageUrl).IsRequired();
            builder.Property(a => a.IsDeleted).HasDefaultValue(false);
            builder.Property(a => a.CreatedTime).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(a => a.ModifiedTime).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
