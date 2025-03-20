namespace IceDream.Contracts.Events
{
    public interface IProductCreated
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
        Guid ImageId { get; }
        Guid CategoryId { get; }
    }
}
