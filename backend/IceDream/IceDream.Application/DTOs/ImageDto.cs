using IceDream.Domain.Entities;

namespace IceDream.Application.DTOs
{
    public class ImageDto : AbstractDto
    {
        public byte[] File { get; set; }
        public bool Main { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
