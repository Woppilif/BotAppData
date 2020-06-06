using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotAppData.Models.Configurations
{
    class ProductItemsConfigurations : IEntityTypeConfiguration<ProductItems>
    {
        public void Configure(EntityTypeBuilder<ProductItems> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired();
            builder.Property(prop => prop.Price).IsRequired();
            builder.Property(prop => prop.Ages).IsRequired();
        }
    }
}
