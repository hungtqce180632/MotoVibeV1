using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class Wishlist
    {
        [Key]
        public int Wishlist_id { get; set; }

        public int Customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        public int Motorbike_id { get; set; }
        public virtual Motorbike Motorbike { get; set; }
    }
}