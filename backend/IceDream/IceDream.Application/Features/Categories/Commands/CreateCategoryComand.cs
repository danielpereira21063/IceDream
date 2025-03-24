namespace IceDream.Application.Features.Categories.Commands
{
    public record CreateCategoryComand
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
