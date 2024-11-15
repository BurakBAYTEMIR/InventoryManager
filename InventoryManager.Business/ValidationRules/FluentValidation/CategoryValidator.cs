using FluentValidation;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Katagori adı boş geçilemez");
        }
    }
}