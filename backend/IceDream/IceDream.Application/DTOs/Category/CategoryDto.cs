﻿namespace IceDream.Application.DTOs.Cateory
{
    public record CategoryDto : AbstractDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
