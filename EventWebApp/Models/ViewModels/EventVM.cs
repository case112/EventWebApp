using System;
using System.Collections.Generic;

namespace EventWebApp.Models.ViewModels
{
    public class EventVM
    {
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Attendee> Attendees { get; set; }
    }
}
