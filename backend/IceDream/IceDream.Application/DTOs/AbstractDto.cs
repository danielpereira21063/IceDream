namespace IceDream.Application.DTOs
{
    public abstract record AbstractDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
