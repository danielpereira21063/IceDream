using FluentValidation;
using IceDream.Application.DTOs.Cateory;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Validators.Category
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(CategoryErrorMessage.CategoryIdRequiredForUpdate);
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(CategoryErrorMessage.InvalidName)
                .MinimumLength(3).WithMessage(CategoryErrorMessage.InvalidName);
        }
    }
}
