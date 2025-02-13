using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_id { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Employee_id { get; set; }
        public virtual Employee Employee { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_start { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_end { get; set; }

        public bool Appointment_status { get; set; }
        public string Note { get; set; }
    }
}
