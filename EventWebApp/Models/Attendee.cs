using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventWebApp.Models
{

    public enum Payment
    {
        Maksmisviis,
        Pangaülekanne,
        Sularaha
    }


    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Name { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        [Range(10000000, 99999999999, ErrorMessage = "Palun sisetage korrektse pikkusega kood.")]
        public long IdCode { get; set; }

        public int? ParticipantCount { get; set; }

        [Range(1, 2, ErrorMessage = "Palun vali maksmisviis.")]
        public Payment Payment { get; set; }

        [StringLength(5000)]
        public string Details { get; set; }

    }
}
