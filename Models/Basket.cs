using System.ComponentModel.DataAnnotations;

namespace server_side.Models
{
    public class Basket
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
