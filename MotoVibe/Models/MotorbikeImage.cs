using System.ComponentModel.DataAnnotations;

namespace MotoVibe.Models
{
    public class MotorbikeImage
    {
        [Key]
        public int Image_id { get; set; }

        public int Motorbike_id { get; set; }
        public virtual Motorbike Motorbike { get; set; }

        public byte[] Picture { get; set; }
    }
}