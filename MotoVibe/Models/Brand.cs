using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Brand
    {
        [Key]
        public int Brand_id { get; set; }

        [Required]
        public string Brand_name { get; set; }

        [Required]
        public string Country_of_origin { get; set; }

        public string Description { get; set; }
    }
}