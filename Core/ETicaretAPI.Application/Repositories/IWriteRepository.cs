using System;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
		Task<bool> AddAsync(T model);
		Task<bool> AddRangeAsync(List<T> datas);
		bool Remove(T model);
		Task<bool> Remove(string id);
		bool Update(T model);
		bool RemoveRange(List<T> datas);


        Task<int> SaveChanges();

	}
}

