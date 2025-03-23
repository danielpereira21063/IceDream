namespace IceDream.Application.DTOs.Cateory
{
    public record UpdateCategoryDto : AbstractUpdateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
