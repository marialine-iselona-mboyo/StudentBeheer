using System.ComponentModel.DataAnnotations;

namespace StudentBeheer.Models
{
    public class Shop
    {
        [Required]
        public char ID { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }


    }
}
