using c135api.DTOs.BlokDtos;
using c135api.Entities;

namespace c135api.DTOs.FloorDtos
{
    public class FloorToListDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public BlokToListDto Blok { get; set; }
    }
}
