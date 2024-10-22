using System.ComponentModel.DataAnnotations;

namespace projetiot.Models
{
    public class IOTdata
    {
        [Key]
        public int Id { get; set; }
        public String? Temperature { get; set; }

        public String? Hmidite { get; set; }
        
        public String? vitesse { get; set; }
        public String? soleil { get; set; }


    }
}
