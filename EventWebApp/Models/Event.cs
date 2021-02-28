using System;
using System.ComponentModel.DataAnnotations;
using EventWebApp.CustomValidation;

namespace EventWebApp.Models
{
    

    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        [DateFutureOnly(ErrorMessage = "Ürituse toimumisaeg peab olema tulevikus!")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Location { get; set; }

        [StringLength(1000, ErrorMessage = "Maksimaalne pikkus on 1000 tähemärki.")]
        public string Details { get; set; }

    }
}
