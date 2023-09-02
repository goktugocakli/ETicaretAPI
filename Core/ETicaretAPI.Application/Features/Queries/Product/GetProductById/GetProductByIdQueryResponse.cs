﻿using System;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Features.Queries.Product.GetProductById
{
	public class GetProductByIdQueryResponse
	{
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        
        
	}
}

