using System;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistance.Contexts
{
	public class ETicaretAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
	{
		public ETicaretAPIDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case (EntityState.Added):
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;

                    case (EntityState.Modified):
                        data.Entity.UpdatedDate = DateTime.UtcNow;
                        break;
                }

            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

