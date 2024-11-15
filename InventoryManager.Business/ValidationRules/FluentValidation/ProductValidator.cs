using FluentValidation;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş Geçilemez");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalı");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Stok sayısı boş Geçilemez");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Fiyat boş Geçilemez");
        }
    }
}