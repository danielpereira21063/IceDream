using IceDream.Application.DTOs.Image;

namespace IceDream.Application.Services.Interfaces
{
    internal interface IIMageService
    {
        Task<ImageDto> CreateImageAsync(CreateImageDto dto);
        Task<ImageDto> UpdateImageAsync(UpdateImageDto dto);
        Task<ImageDto> GetImageByIdAsync(int id);
        Task<IEnumerable<ImageDto>> GetAllImagesAsync();
    }
}
