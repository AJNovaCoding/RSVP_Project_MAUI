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
        public string EventName { get; set; } = string.Empty; // Default value added
        public string Date { get; set; } = string.Empty; // Default value added
        public string Time { get; set; } = string.Empty; // Default value added
        public string Location { get; set; } = string.Empty; // Default value added
        public int HostUserId { get; set; }
        public string Description { get; set; } = string.Empty; // Default value added
    }
}
