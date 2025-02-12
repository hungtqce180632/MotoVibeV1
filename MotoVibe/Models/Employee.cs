using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Employee
    {
        [Key]
        public int Employee_id { get; set; }

        public int User_id { get; set; }
        public virtual UserAccount UserAccount { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Phone_number { get; set; }
    }
}