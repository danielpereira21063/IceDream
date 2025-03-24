using IceDream.Application.Features.Products.Commands;
using IceDream.Application.Services.Interfaces;

namespace IceDream.Application.Services
{
    public class ProductService : IProductService
    {
        public Task<UpdateProductCommand> CreateProductAsync(UpdateProductCommand dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UpdateProductCommand>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateProductCommand> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductCommand dto)
        {
            throw new NotImplementedException();
        }
    }
}
