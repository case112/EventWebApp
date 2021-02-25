using System;
using System.ComponentModel.DataAnnotations;

namespace EventWebApp.Models
{
    public class Participant
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
