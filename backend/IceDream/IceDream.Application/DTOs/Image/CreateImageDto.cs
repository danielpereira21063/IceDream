namespace IceDream.Application.DTOs.Image
{
    public record CreateImageDto
    {
        public byte[] File { get; set; }
        public bool Main { get; set; }
        public Guid ProductId { get; set; }
    }
}
