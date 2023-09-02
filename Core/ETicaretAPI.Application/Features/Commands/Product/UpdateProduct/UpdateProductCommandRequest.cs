
using System;
using MediatR;

using ETicaretAPI.Application.ViewModels.Products;

namespace ETicaretAPI.Application.Features.Commands.Product.UpdateProduct
{
	public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
	{
		public VM_Update_Product Update_Product { get; set; }
	}
}

