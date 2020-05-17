using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models.Configurations
{
    class BroadcastConfigurations : IEntityTypeConfiguration<Broadcast>
    {
        public void Configure(EntityTypeBuilder<Broadcast> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Message).IsRequired();
            builder.Property(prop => prop.MessageAt).HasColumnType("TIMESTAMP(0)").IsRequired();
            builder.Property(prop => prop.Group).IsRequired();
        }
    }
}
