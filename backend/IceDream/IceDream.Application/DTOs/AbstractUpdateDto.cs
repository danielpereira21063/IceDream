namespace IceDream.Application.DTOs
{
    public abstract record AbstractUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
