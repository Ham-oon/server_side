using System.ComponentModel.DataAnnotations;

namespace server_side.Models
{
    public class Users
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        public string Name { get; set; }

        [StringLength (100)]
        [Required]
        public string Family { get; set; }


        [StringLength (100)]
        public string Fathername { get; set; }


        [StringLength (100)]
        [Required]
        public string Password { get; set; }

        public DateTime?  Birthday { get; set; }
        public bool? Gender { get; set; }
        // nullable with ?
        public bool Active { get; set; }

    }
}