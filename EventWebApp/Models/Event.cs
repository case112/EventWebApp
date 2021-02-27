using System;
using System.ComponentModel.DataAnnotations;
using EventWebApp.CustomValidation;

namespace EventWebApp.Models
{


    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        [DateFutureOnly(ErrorMessage = "Ürituse toimumisaeg peab olema tulevikus!")]
        public DateTime StartDate { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }

    }
}
