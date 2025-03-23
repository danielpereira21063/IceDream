using IceDream.Application.DTOs.Cateory;
using System;

namespace IceDream.Application.Services.Interfaces
{
    internal interface ICategoryService
    {
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto dto);
        Task<CategoryDto> UpdateCategoryAsync(UpdateCategoryDto dto);
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
    }
}
