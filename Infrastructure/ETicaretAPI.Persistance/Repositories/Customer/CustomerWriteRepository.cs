using System;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories
{
	public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
	{

        public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}

