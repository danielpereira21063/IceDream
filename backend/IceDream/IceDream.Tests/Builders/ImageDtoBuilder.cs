using AutoFixture;
using IceDream.Application.DTOs;

namespace IceDream.Tests.Builders
{
    internal class ImageDtoBuilder : AbstractDtoBuiderBase
    {
        Guid _productId = Guid.NewGuid();
        byte[] _file = new byte[1];
        bool _main = true;

        internal ImageDtoBuilder WithProductId(Guid productId)
        {
            _productId = productId;
            return this;
        }

        internal ImageDtoBuilder WithFile(byte[]? file)
        {
            _file = file;
            return this;
        }

        internal ImageDtoBuilder WithMain(bool main)
        {
            _main = main;
            return this;
        }

        internal ImageDto Build()
        {
            return new ImageDto
            {
                Id = Id,
                CreatedAt = CreatedAt,
                UpdatedAt = CreatedAt,
                ProductId = _productId,
                File = _file,
                Main = _main
            };
        }
    }
}
