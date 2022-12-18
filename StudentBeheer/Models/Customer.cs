using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentBeheer.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Voornaam")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Geboortedatum")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


        [ForeignKey("Shop")]
        public char GenderId { get; set; }
        public Shop? Gender { get; set; }
        public DateTime? Deleted { get; set; } = DateTime.MaxValue;



        public DateTime Started { get; set; }

        [Display(Name = "Beëindigd")]
        [DataType(DataType.Date)]
        public DateTime Ended { get; set; }

    }
}
