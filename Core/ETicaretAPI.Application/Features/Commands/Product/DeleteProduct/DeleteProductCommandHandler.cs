using System;
using ETicaretAPI.Application.Repositories;
using MediatR;
namespace ETicaretAPI.Application.Features.Commands.Product.DeleteProduct
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
	{

        IProductWriteRepository _productWriteRepository;

		public DeleteProductCommandHandler(IProductWriteRepository productWriteRepository)
		{
            _productWriteRepository = productWriteRepository;
		}

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _productWriteRepository.Remove(request.Id);
            await _productWriteRepository.SaveChanges();
            return new();
        }
    }
}

