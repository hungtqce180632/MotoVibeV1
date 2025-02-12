using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Inventory
    {
        [Key]
        public int Inventory_id { get; set; }

        public int Motorbike_id { get; set; }
        public virtual Motorbike Motorbike { get; set; }

        public int Quantity { get; set; }
    }
}