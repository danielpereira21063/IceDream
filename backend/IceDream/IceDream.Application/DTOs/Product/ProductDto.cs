using IceDream.Application.DTOs.Cateory;
using IceDream.Application.DTOs.Image;

namespace IceDream.Application.DTOs.Product
{
    public record ProductDto : AbstractDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid ImageId { get; set; }
        public ImageDto Image { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
