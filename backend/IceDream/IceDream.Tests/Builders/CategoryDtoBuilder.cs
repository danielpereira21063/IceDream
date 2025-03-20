using IceDream.Application.DTOs;

namespace IceDream.Tests.Builders
{
    internal class CategoryDtoBuilder : AbstractDtoBuiderBase
    {

        private string _name = "Ice Cream";
        private string _description = "Ice Cream category";

        internal CategoryDtoBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        internal CategoryDtoBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        internal CategoryDto Build()
        {
            return new CategoryDto
            {
                Id = Id,
                Name = _name,
                Description = _description,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };
        }
    }
}
