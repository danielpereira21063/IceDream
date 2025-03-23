namespace IceDream.Application.DTOs.Cateory
{
    public record CreateCategoryDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
