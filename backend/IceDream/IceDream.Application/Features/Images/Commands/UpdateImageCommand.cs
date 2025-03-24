namespace IceDream.Application.Features.Images.Commands
{
    public record UpdateImageCommand
    {
        public Guid Id { get; set; }
        public byte[] File { get; set; }
        public bool Main { get; set; }
        public Guid ProductId { get; set; }
    }
}
