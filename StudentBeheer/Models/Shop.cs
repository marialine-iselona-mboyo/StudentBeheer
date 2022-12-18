using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace StudentBeheer.Models
{

    [Authorize(Roles = "Admin")]
    public class Shop
    {
        [Required]
        public char Id { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }


    }
}
