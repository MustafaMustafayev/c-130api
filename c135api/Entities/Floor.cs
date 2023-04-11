using System.ComponentModel.DataAnnotations.Schema;

namespace c135api.Entities
{
    public class Floor
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Blok Blok { get; set; } 
        [ForeignKey("Blok")]
        public int? BlokId { get; set; } 
        public bool IsDeleted { get; set; } 
    }
}
