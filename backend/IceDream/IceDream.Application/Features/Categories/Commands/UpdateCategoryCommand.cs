namespace IceDream.Application.Features.Categories.Commands
{
    public record UpdateCategoryCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
