using IceDream.Data.Context;
using IceDream.Data.Repositories.Interfaces;
using IceDream.Domain.Entities;

namespace IceDream.Data.Repositories
{
    public class ProductRepository
        : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IceDreamContext context)
            : base(context)
        {
        }
    }
}
