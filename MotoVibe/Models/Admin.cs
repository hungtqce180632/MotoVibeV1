using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Admin
    {
        [Key]
        public int Admin_id { get; set; }

        public int User_id { get; set; }
        public virtual UserAccount UserAccount { get; set; }

        [Required]
        public string Name { get; set; }
    }
}