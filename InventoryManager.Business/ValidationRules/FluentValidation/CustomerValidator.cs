using FluentValidation;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Müşteri sehri boş Geçilemez");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri adı boş Geçilemez");
        }
    }
}