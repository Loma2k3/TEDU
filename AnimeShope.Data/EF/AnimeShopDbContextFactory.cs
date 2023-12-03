using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimeShope.Data.EF
{
	class AnimeShopDbContextFactory : IDesignTimeDbContextFactory<AnimeShopDbContext>
	{
		public AnimeShopDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot conf = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connection = conf.GetConnectionString("AnimeShopDb");

			var optionsBuilder = new DbContextOptionsBuilder<AnimeShopDbContext>();
			optionsBuilder.UseSqlServer(connection);

			return new AnimeShopDbContext(optionsBuilder.Options);
		}
	}
}
