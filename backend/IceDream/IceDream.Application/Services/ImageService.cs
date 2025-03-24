using IceDream.Application.DTOs.Image;
using IceDream.Application.Features.Images.Commands;
using IceDream.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceDream.Application.Services
{
    public class ImageService : IIMageService
    {
        public Task<ImageDto> CreateImageAsync(CreateImageCommand dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ImageDto>> GetAllImagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImageDto> GetImageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ImageDto> UpdateImageAsync(UpdateImageCommand dto)
        {
            throw new NotImplementedException();
        }
    }
}
