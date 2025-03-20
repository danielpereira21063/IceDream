namespace IceDream.Tests.Builders
{
    internal abstract class AbstractDtoBuiderBase
    {
        protected Guid Id = Guid.NewGuid();
        protected DateTime CreatedAt = DateTime.Now;
        protected DateTime? UpdatedAt = null;

        internal AbstractDtoBuiderBase WithCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
            return this;
        }

        internal AbstractDtoBuiderBase WithUpdatedAt(DateTime updatedAt)
        {
            UpdatedAt = updatedAt;
            return this;
        }
    }
}
