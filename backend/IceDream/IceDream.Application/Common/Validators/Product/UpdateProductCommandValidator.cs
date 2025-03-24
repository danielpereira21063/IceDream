using FluentValidation;
using IceDream.Application.Features.Products.Commands;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Common.Validators.Product
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(ProductErrorMessage.ProductIdRequiredForUpdate);

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(ProductErrorMessage.InvalidName)
                .MinimumLength(3).WithMessage(ProductErrorMessage.InvalidName);

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage(ProductErrorMessage.InvalidPrice);

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage(ProductErrorMessage.InvalidCategoryId);
        }
    }
}
