using IceDream.Application.DTOs.Product;

namespace IceDream.Application.DTOs.Image
{
    public record ImageDto : AbstractDto
    {
        public byte[] File { get; set; }
        public bool Main { get; set; }
        public Guid ProductId { get; set; }
    }
}
