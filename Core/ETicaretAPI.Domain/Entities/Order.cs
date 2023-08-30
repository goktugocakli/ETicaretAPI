using System;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
	public class Order : BaseEntity
	{
		public string Description { get; set; }

		public string Address { get; set; }

		public ICollection<Product> Products{ get; set; }


		public Guid CustomerId { get; set; }
		public Customer customer { get; set; }

		public Order()
		{
		}
	}
}

