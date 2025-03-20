using FluentAssertions;
using IceDream.Domain.Entities;
using IceDream.Tests.Builders;
using Xunit;

namespace IceDream.Tests.Entities
{
    public class ImageTest
    {
        private readonly ImageDtoBuilder _builder = new ImageDtoBuilder();

        [Fact]
        public void ShouldCreateImage()
        {
            var image = _builder.Build();
            Action action = () => new Image(image.ProductId, image.File, image.Main);
            action.Should().NotThrow();
        }
    }
}
