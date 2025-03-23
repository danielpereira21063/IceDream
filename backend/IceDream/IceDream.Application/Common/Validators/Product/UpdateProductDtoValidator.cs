using FluentValidation;
using IceDream.Application.DTOs.Product;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Validators.Product
{
    public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductDtoValidator()
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
