using IceDream.Application.DTOs.Product;
using IceDream.Application.Services.Interfaces;

namespace IceDream.Application.Services
{
    public class ProductService : IProductService
    {
        public Task<UpdateProductDto> CreateProductAsync(UpdateProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UpdateProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateProductDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
