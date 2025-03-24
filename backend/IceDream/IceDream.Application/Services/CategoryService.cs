using IceDream.Application.DTOs.Cateory;
using IceDream.Application.Features.Categories.Commands;
using IceDream.Application.Services.Interfaces;

namespace IceDream.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<CategoryDto> CreateCategoryAsync(CreateCategoryComand dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> UpdateCategoryAsync(UpdateCategoryCommand dto)
        {
            throw new NotImplementedException();
        }
    }
}
