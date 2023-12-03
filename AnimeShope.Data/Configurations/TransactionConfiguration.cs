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
	class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
	{
		public void Configure(EntityTypeBuilder<Transaction> builder)
		{
			builder.ToTable("Transactions");
			
			builder.HasKey( x => x.Id);

			builder.Property(x=>x.Id).UseIdentityColumn();
		}
	}
}
