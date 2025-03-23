namespace IceDream.Application.DTOs.Product
{
    public record UpdateProductDto : AbstractUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid ImageId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
