using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Review
    {
        [Key]
        public int Review_id { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Motorbike_id { get; set; }
        public virtual Motorbike Motorbike { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public string Review_text { get; set; }

        [DataType(DataType.Date)]
        public DateTime Review_date { get; set; }

        public bool Review_status { get; set; }
    }
}