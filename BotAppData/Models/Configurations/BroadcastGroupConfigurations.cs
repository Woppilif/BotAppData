﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models.Configurations
{
    class BroadcastGroupConfigurations : IEntityTypeConfiguration<BroadcastGroup>
    {
        public void Configure(EntityTypeBuilder<BroadcastGroup> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired();
            builder.Property(prop => prop.Age).IsRequired();
            builder.Property(prop => prop.Type).IsRequired();
            builder.Property(prop => prop.Creator).IsRequired();
        }
    }
}
