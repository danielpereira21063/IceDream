using IceDream.Application.DTOs.Image;
using IceDream.Application.Features.Images.Commands;

namespace IceDream.Application.Services.Interfaces
{
    internal interface IIMageService
    {
        Task<ImageDto> CreateImageAsync(CreateImageCommand dto);
        Task<ImageDto> UpdateImageAsync(UpdateImageCommand dto);
        Task<ImageDto> GetImageByIdAsync(int id);
        Task<IEnumerable<ImageDto>> GetAllImagesAsync();
    }
}
