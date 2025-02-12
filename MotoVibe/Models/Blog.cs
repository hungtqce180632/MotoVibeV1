using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Blog
    {
        [Key]
        public int Blog_id { get; set; }

        public int Admin_id { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        public string Blog_name { get; set; }

        [Required]
        public string Blog_details { get; set; }

        public byte[] Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_start { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_end { get; set; }

        public bool Blog_status { get; set; }
    }
}