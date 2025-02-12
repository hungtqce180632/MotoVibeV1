using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Fuel
    {
        [Key]
        public int Fuel_id { get; set; }

        [Required]
        public string Fuel_name { get; set; }
    }
}