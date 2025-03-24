using FluentValidation;
using IceDream.Application.Features.Images.Commands;

namespace IceDream.Application.Common.Validators.Image
{
    public class CreateImageCommandValidator : AbstractValidator<CreateImageCommand>
    {
        public CreateImageCommandValidator()
        {
            
        }
    }
}
