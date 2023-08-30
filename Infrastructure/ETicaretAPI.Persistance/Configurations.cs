using System;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistance
{
	static class Configurations
	{
		public static string ConnectionString
			{

			get
			{
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
				return configurationManager.GetConnectionString("postgreSQL");
            }

		}

	}
}

