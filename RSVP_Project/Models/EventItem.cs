using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSVP_Project.Models
{
    public class EventItem
    {
        [PrimaryKey, AutoIncrement]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public int HostUserId { get; set; }
        public string  Description { get; set; }

    }
}
