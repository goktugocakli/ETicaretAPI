using System;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories
{
	public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
	{
		
        public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}

