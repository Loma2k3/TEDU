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
	class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
	{
		public void Configure(EntityTypeBuilder<ProductTranslation> builder)
		{
			builder.ToTable("ProductTranslations");
			builder.HasKey(t => t.Id);

			builder.Property(t => t.Id).UseIdentityColumn();

			builder.Property(t=> t.Name).IsRequired().HasMaxLength(200);

			builder.Property(t=> t.SeoAlias).IsRequired().HasMaxLength(200);

			builder.Property(t=> t.Details).HasMaxLength(500);

			builder.Property(t=> t.LanguageId).IsUnicode(false).HasMaxLength(5).IsRequired();

			builder.HasOne(t=>t.Product).WithMany(t=> t.ProductTranslations)
				.HasForeignKey(t => t.ProductId);

			builder.HasOne(t => t.Language).WithMany(t => t.ProductTranslations)
				.HasForeignKey(t => t.LanguageId);
		}
	}
}
