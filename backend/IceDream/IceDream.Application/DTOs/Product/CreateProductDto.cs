namespace IceDream.Application.DTOs
{
    public record CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid ImageId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
