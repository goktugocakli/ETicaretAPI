using System;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories
{
	public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
	{
	
        public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}

