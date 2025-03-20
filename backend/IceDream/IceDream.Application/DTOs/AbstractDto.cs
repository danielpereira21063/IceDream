namespace IceDream.Application.DTOs
{
    public abstract class AbstractDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
