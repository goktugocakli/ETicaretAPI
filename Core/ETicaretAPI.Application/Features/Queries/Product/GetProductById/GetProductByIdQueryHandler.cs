using System;
using MediatR;
using ETicaretAPI.Application.Repositories;

namespace ETicaretAPI.Application.Features.Queries.Product.GetProductById
{
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
	{
		IProductReadRepository _productReadRepository;


		public GetProductByIdQueryHandler(IProductReadRepository productReadRepository)
		{
			_productReadRepository = productReadRepository;
		}

        public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
			Domain.Entities.Product product = await _productReadRepository.GetByIdAsync(request.Id, false);
			return new()
			{
				Name = product.Name,
				Price = product.Price,
				Stock = product.Stock
			};
        }
    }
}

