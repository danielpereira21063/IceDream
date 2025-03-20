namespace IceDream.Domain.Entities
{
    public abstract class AbstractEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; protected set; }

        protected AbstractEntity()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
                CreatedAt = DateTime.Now;
            }
        }
    }
}
