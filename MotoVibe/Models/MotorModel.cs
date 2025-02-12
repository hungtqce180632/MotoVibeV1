using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class MotorModel
    {
        [Key]
        public int Model_id { get; set; }

        [Required]
        public string Model_name { get; set; }
    }
}