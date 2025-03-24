using FluentValidation;
using IceDream.Application.Features.Categories.Commands;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Common.Validators.Category
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryCommand>
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
