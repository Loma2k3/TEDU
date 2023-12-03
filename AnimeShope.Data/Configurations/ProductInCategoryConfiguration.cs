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
	public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
	{
		public void Configure(EntityTypeBuilder<ProductInCategory> builder)
		{
			builder.HasKey(x => new {x.CategoryId, x.ProductId});

			builder.ToTable("ProductInCategories");

			builder.HasOne(t => t.Product).WithMany(pc=> pc.ProductInCategories)
				.HasForeignKey(pc=>pc.ProductId);

			builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
				.HasForeignKey(pc => pc.CategoryId);
		}
	}
}
