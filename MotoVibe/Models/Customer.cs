using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Customer
    {
        [Key]
        public int Customer_id { get; set; }

        public int User_id { get; set; }
        public virtual UserAccount UserAccount { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Picture { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public string Cus_id_number { get; set; }
        public string Preferred_contact_method { get; set; }
    }
}