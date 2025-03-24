using FluentValidation;
using IceDream.Application.Features.Products.Commands;

namespace IceDream.Application.Common.Validators.Product
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
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
