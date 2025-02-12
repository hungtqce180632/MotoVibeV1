using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Warranty
    {
        [Key]
        public int Warranty_id { get; set; }

        public int Order_id { get; set; }
        public virtual Order Order { get; set; }

        public string Warranty_details { get; set; }

        [DataType(DataType.Date)]
        public DateTime Warranty_expiry { get; set; }
    }
}   