using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Order
    {
        [Key]
        public int Order_id { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Employee_id { get; set; }
        public virtual Employee Employee { get; set; }

        public int Motorbike_id { get; set; }
        public virtual Motorbike Motorbike { get; set; }

        public string Payment_method { get; set; }
        public bool Payment_status { get; set; }
        public bool Order_status { get; set; }

        public decimal Total_amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_start { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_end { get; set; }

        public string Frame_number_motorbike { get; set; }
        public string Engine_number_motorbike { get; set; }
    }
}