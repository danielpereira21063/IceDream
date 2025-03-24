namespace IceDream.Application.Features.Images.Commands
{
    public record CreateImageCommand
    {
        public byte[] File { get; set; }
        public bool Main { get; set; }
        public Guid ProductId { get; set; }
    }
}
