using FluentValidation;
using IceDream.Application.Features.Categories.Commands;
using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Application.Common.Validators.Category
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryComand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(CategoryErrorMessage.InvalidName)
                .MinimumLength(3).WithMessage(CategoryErrorMessage.InvalidName);
        }
    }
}
