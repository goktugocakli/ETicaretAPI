using System;
using ETicaretAPI.Application.ViewModels.Products;
using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
	{

        public VM_Create_Product Product { get; set; }
		
	}
}

