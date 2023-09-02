using System;
using ETicaretAPI.Application.Abstractions.Token;
using ETicaretAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Infrastructure
{
	public static class InfrastructureServices
	{
		public static void AddInfrastructureServices(this IServiceCollection serviceCollection )
		{
			serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
		}
	}
}

