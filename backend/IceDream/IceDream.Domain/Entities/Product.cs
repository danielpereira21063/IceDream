using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Domain.Entities
{
    public sealed class Product : AbstractEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public Guid ImageId { get; private set; }
        public Image Image { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }

        public Product(Guid imageId, Guid categoryId, string name, string description, decimal price)
        {
            Validate(imageId, categoryId, name, description, price);
            Name = name;
            Description = description;
            Price = price;
            ImageId = imageId;
            CategoryId = categoryId;
        }

        private void Validate(Guid imageId, Guid categoryId, string name, string description, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 3)
            {
                throw new ArgumentException(ProductErrorMessage.InvaldiName);
            }

            if (string.IsNullOrWhiteSpace(description) || description.Length <= 3)
            {
                throw new ArgumentException(ProductErrorMessage.InvalidDescription);
            }

            if (price <= 0)
            {
                throw new ArgumentException(ProductErrorMessage.InvalidPrice);
            }

            if (imageId == Guid.Empty)
            {
                throw new ArgumentException(ProductErrorMessage.InvalidImageId);
            }

            if (categoryId == Guid.Empty)
            {
                throw new ArgumentException(ProductErrorMessage.InvalidCategoryId);
            }
        }
    }
}
