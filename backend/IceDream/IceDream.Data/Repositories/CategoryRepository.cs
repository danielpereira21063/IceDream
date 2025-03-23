using IceDream.Data.Context;
using IceDream.Data.Repositories.Interfaces;
using IceDream.Domain.Entities;

namespace IceDream.Data.Repositories
{
    public class CategoryRepository
        : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IceDreamContext context)
            : base(context)
        {
        }
    }
}
