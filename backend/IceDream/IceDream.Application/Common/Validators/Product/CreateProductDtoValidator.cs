using FluentValidation;
using IceDream.Application.DTOs;

namespace IceDream.Application.Validators.Product
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(ProductErrorMessage.InvalidName)
                .MinimumLength(4).WithMessage(ProductErrorMessage.InvalidName);

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage(ProductErrorMessage.InvalidPrice);

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage(ProductErrorMessage.InvalidCategoryId);
        }
    }
}
