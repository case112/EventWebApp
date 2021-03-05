using System;
using System.Collections.Generic;

namespace EventWebApp.Models.ViewModels
{
    public class EventPastFutureVM
    {
        public IEnumerable<Event> EventsPast { get; set; }
        public IEnumerable<Event> EventsFuture { get; set; }
    }
}