using IceDream.Application.Features.Products.Commands;

namespace IceDream.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<UpdateProductCommand> CreateProductAsync(UpdateProductCommand dto);
        Task<IEnumerable<UpdateProductCommand>> GetAllProductsAsync();
        Task<UpdateProductCommand> GetProductByIdAsync(int id);
        Task UpdateProductAsync(UpdateProductCommand dto);
    }
}
