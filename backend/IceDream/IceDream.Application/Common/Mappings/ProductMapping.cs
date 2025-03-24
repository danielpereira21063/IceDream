using IceDream.Application.DTOs.Product;
using IceDream.Application.Features.Products.Commands;
using IceDream.Domain.Entities;

namespace IceDream.Application.Common.Mappings
{
    public static class ProductMapping
    {
        public static Product ToProduct(this ProductDto product)
        {
            return new Product(product.ImageId, product.CategoryId, product.Name, product.Description, product.Price);
        }

        public static Product ToProduct(this UpdateProductCommand product)
        {
            return new Product(product.ImageId, product.CategoryId, product.Name, product.Description, product.Price);
        }

        public static Product ToProduct(this CreateProductCommand product)
        {
            return new Product(product.ImageId, product.CategoryId, product.Name, product.Description, product.Price);
        }

        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                ImageId = product.ImageId,
                CategoryId = product.CategoryId,
                CreatedAt = product.CreatedAt,
                Price = product.Price,
                Name = product.Name,
                Description = product.Description,
                UpdatedAt = product.UpdatedAt
            };
        }
    }
}
