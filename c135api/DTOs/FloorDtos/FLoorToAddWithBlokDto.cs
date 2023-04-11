using c135api.DTOs.BlokDtos;

namespace c135api.DTOs.FloorDtos
{
    public record FLoorToAddWithBlokDto
    {
        public string Number { get; set; }
        public BlokToAddDto Blok { get; set; }
    }
}
