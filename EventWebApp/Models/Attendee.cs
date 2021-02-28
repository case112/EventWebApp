using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventWebApp.Models
{

    public enum Payment
    {
        Pangaülekanne,
        Sularaha
    }


    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public string Name { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public int IdCode { get; set; }

        [Required(ErrorMessage = "See on kohustuslik väli!")]
        public int ParticipantCount { get; set; }

        public Payment Payment { get; set; }

        [StringLength(5000)]
        public string Details { get; set; }

    }
}
