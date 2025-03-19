using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Domain.Entities
{
    public sealed class Category : AbstractEntity
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }

        public Category(string name, string description)
        {
            Validate(name, description);
            Name = name;
            Description = description;
        }

        private void Validate(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 3)
            {
                throw new ArgumentException(CategoryErrorMessage.InvalidName, nameof(name));
            }

            if (string.IsNullOrWhiteSpace(description) || description.Length <= 3)
            {
                throw new ArgumentException(CategoryErrorMessage.InvalidDescription, nameof(description));
            }
        }
    }
}