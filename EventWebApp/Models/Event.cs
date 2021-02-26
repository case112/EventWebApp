using System;
using System.ComponentModel.DataAnnotations;

namespace EventWebApp.Models
{


    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm}")]
        public DateTime StartDate { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }

    }
}
