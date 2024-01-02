using System.ComponentModel.DataAnnotations;

namespace server_side.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        public string Name { get; set; }

        [StringLength (100)]
        public string Description { get; set; }

        [Required]
        public bool? Available { get; set; }
        // nullable with ?


        [Required]
        public float? Price { get; set; }

    
    }
}