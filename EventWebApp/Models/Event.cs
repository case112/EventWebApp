using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EventWebApp.CustomValidation;

namespace EventWebApp.Models
{
    

    public class Event
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ürituse nimi")]
        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Name { get; set; }

        [DisplayName("Toimumisaeg")]
        [Required(ErrorMessage = "See on kohustuslik väli!")]
        [DateFutureOnly(ErrorMessage = "Ürituse toimumisaeg peab olema tulevikus!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("Koht")]
        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Location { get; set; }

        [DisplayName("Lisainfo")]
        [StringLength(1000, ErrorMessage = "Maksimaalne pikkus on 1000 tähemärki.")]
        public string Details { get; set; }

    }
}
