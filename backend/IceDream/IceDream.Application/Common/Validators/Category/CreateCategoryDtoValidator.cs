using FluentValidation;
using IceDream.Application.DTOs.Cateory;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Validators.Category
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(CategoryErrorMessage.InvalidName)
                .MinimumLength(3).WithMessage(CategoryErrorMessage.InvalidName);
        }
    }
}
