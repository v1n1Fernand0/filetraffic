using FileTraffic.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Infra.Data.EntitiesConfiguration
{
    internal class ArchiveConfiguration : IEntityTypeConfiguration<Archive>
    {
        public void Configure(EntityTypeBuilder<Archive> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.UserCreater).IsRequired();
            builder.Property(x => x.UserUpdater).IsRequired();
            builder.Property(x => x.Extension).IsRequired();
            builder.HasOne(x => x.Folder).WithMany(x => x.Archives).HasForeignKey(x => x.Id);
        }
    }
}
