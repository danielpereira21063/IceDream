using FluentValidation;
using IceDream.Application.Validators.Product;
using Microsoft.Extensions.DependencyInjection;

namespace IceDream.DependencyInjection.Extensions
{
    public static class FluentValidationEx
    {
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CreateProductDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<UpdateProductDtoValidator>();
        }
    }
}
