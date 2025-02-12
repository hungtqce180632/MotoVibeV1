using System;
using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Motorbike
    {
        [Key]
        public int Motorbike_id { get; set; }

        [Required]
        public string Motorbike_name { get; set; }

        public int Brand_id { get; set; }
        public virtual Brand Brand { get; set; }

        public int Model_id { get; set; }
        public virtual MotorModel Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_start { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public int Fuel_id { get; set; }
        public virtual Fuel Fuel { get; set; }

        public string Description { get; set; }
    }
}