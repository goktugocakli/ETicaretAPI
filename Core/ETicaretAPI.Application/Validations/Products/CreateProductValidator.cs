using System;
using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validations.Products
{
	public class CreateProductValidator : AbstractValidator<VM_Create_Product>
	{
		public CreateProductValidator()
		{
			RuleFor(p => p.Name)
				.NotEmpty()
				.NotNull()
					.WithMessage("Lütfen Ürünün Adını Yazınız.")
				.MaximumLength(255);

			RuleFor(p => p.Stock)
				.NotEmpty()
				.NotNull()
					.WithMessage("Lütfen stok bilgisini boş bırakmayınız")
				.Must(s => s >= 0)
					.WithMessage("Stok bilgisini negatif olamaz");

			RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Fiyat bilgisini boş bırakmayınız")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisini negatif olamaz");

        }
	}
}

