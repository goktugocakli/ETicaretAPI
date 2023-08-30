using System;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaretAPI.Persistance
{
	public class DesignTimeDbContext : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
	{
		public DesignTimeDbContext()
		{
		}

        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

