using AnimeShope.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeShope.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x=>x.Id);

            builder.Property(x=> x.Id).UseIdentityColumn();

            builder.Property(x=>x.Price).IsRequired(true);

            builder.Property(x=>x.OriginalPrice).IsRequired(true);

            builder.Property(x=>x.Stock).IsRequired(true).HasDefaultValue(0);

            builder.Property(x=>x.ViewCount).IsRequired(true).HasDefaultValue(0);


        }
    }
}
