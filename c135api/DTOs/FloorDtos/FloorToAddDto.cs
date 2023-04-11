using c135api.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace c135api.DTOs.FloorDtos
{
    public record FloorToAddDto
    {
        public string Number { get; set; }
        public int BlokId { get; set; }
    }
}
