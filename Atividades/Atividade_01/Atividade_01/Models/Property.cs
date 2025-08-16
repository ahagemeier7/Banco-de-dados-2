using System.ComponentModel.DataAnnotations;

namespace Atividade_01.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string? Colour { get; set; }
        public string? SizeM2 { get; set; }
        public int BedroomNumber { get; set; }
        public int BathroomNumber { get; set; }
        public float Value { get; set; }
        
    }
}
