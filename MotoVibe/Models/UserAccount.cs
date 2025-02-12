using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class UserAccount
    {
        [Key]
        public int User_id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_created { get; set; }

        public bool Status { get; set; }
    }
}