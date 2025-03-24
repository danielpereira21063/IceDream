using FluentValidation;
using IceDream.Application.Common.Validators.Product;
using Microsoft.Extensions.DependencyInjection;

namespace IceDream.DependencyInjection.Extensions
{
    public static class FluentValidationEx
    {
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CreateProductCommandValidator>();
            services.AddValidatorsFromAssemblyContaining<UpdateProductCommandValidator>();
        }
    }
}
