using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSVP_Project.Models
{
    public class RSVP
    {
        [PrimaryKey, AutoIncrement]
        public int RSVPId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int HostUserId { get; set; }
        public string Name { get; set; } = string.Empty; // Default value added
        public string Email { get; set; } = string.Empty; // Default value added to fix CS8618
        public int NumberOfGuests { get; set; }
    }
}
