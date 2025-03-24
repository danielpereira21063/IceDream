using IceDream.Application.DTOs.Cateory;
using IceDream.Application.Features.Categories.Commands;
using System;

namespace IceDream.Application.Services.Interfaces
{
    internal interface ICategoryService
    {
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryComand dto);
        Task<CategoryDto> UpdateCategoryAsync(UpdateCategoryCommand dto);
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
    }
}
