using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotoVibe.Models
{
    [Table("customers")] // Maps this class to the customers table
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        // Foreign Key to user_account table
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserAccount UserAccount { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("picture")]
        public string Picture { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("cus_id_number")]
        public string CusIdNumber { get; set; }

        [Column("preferred_contact_method")]
        public string PreferredContactMethod { get; set; }
    }
}
