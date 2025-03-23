using IceDream.Data.Context;
using IceDream.Data.Repositories.Interfaces;
using IceDream.Domain.Entities;

namespace IceDream.Data.Repositories
{
    public class ImageRepository
        : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(IceDreamContext context)
            : base(context)
        {
        }
    }
}
