using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotoVibe.Models
{
    [Table("user_account")] // Maps this class to the user_account table
    public class UserAccount
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("role")]
        public string Role { get; set; }

        [Column("date_created")]
        public DateTime DateCreated { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
