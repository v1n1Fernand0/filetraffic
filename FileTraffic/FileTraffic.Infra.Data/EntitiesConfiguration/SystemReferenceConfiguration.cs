﻿using FileTraffic.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Infra.Data.EntitiesConfiguration
{
    public class SystemReferenceConfiguration : IEntityTypeConfiguration<SystemReference>
    {
        public void Configure(EntityTypeBuilder<SystemReference> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Key).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
        }
    }
}