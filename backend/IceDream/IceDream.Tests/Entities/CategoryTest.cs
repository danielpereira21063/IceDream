using FluentAssertions;
using IceDream.Domain.Constants.ErrorMessages;
using IceDream.Domain.Entities;
using IceDream.Tests.Builders;
using Xunit;

namespace IceDream.Tests.Entities
{
    public class CategoryTest
    {
        private readonly CategoryDtoBuilder _builder = new CategoryDtoBuilder();


        [Fact]
        public void ShouldCreateCategory()
        {
            var category = _builder.Build();

            Action action = () => new Category(category.Name, category.Description);

            action.Should().NotThrow();
        }

        [Fact]
        public void ShouldNotCreateCategory_WhenInvalidName()
        {
            var category = _builder.WithName(null).Build();

            Action action = () => new Category(category.Name, category.Description);

            action.Should().Throw<ArgumentException>().WithMessage(CategoryErrorMessage.InvalidName);
        }

        [Fact]
        public void ShouldNotCreateCategory_WhenInvalidDescription()
        {
            var category = _builder.WithDescription(null).Build();

            Action action = () => new Category(category.Name, category.Description);

            action.Should().Throw<ArgumentException>().WithMessage(CategoryErrorMessage.InvalidDescription);
        }
    }
}
    