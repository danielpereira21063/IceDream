using IceDream.Application.DTOs.Product;

namespace IceDream.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<UpdateProductDto> CreateProductAsync(UpdateProductDto dto);
        Task<IEnumerable<UpdateProductDto>> GetAllProductsAsync();
        Task<UpdateProductDto> GetProductByIdAsync(int id);
        Task UpdateProductAsync(UpdateProductDto dto);
    }
}
