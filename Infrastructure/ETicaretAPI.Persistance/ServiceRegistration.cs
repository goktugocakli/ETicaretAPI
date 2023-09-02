using System;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ETicaretAPI.Persistance.Repositories;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Identity;

namespace ETicaretAPI.Persistance
{
	public static class ServiceRegistration
	{
		public static void AddPersistanceServices(this IServiceCollection service)
		{
			service.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));

			service.AddIdentity<AppUser, AppRole>(options =>
			{
				options.Password.RequiredLength = 3;
				options.Password.RequireLowercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
				options.Password.RequireDigit = false;
			}).AddEntityFrameworkStores<ETicaretAPIDbContext>();

			service.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
			service.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
			service.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
			service.AddScoped<IOrderReadRepository, OrderReadRepository>();
			service.AddScoped<IProductReadRepository, ProductReadRepository>();
			service.AddScoped<IProductWriteRepository, ProductWriteRepository>();
		}
	}
}

