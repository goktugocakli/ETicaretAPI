using System;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ETicaretAPI.Persistance.Repositories;
using ETicaretAPI.Application.Repositories;

namespace ETicaretAPI.Persistance
{
	public static class ServiceRegistration
	{
		public static void AddPersistanceServices(this IServiceCollection service)
		{
			service.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configurations.ConnectionString), ServiceLifetime.Singleton);
			service.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
			service.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
			service.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
			service.AddSingleton<IOrderReadRepository, OrderReadRepository>();
			service.AddSingleton<IProductReadRepository, ProductReadRepository>();
			service.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
		}
	}
}

