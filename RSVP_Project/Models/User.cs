using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSVP_Project.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize to avoid null
        public string Email { get; set; } = string.Empty; // Initialize to avoid null
        public string Username { get; set; } = string.Empty; // Initialize to avoid null
        public string Password { get; set; } = string.Empty; // Initialize to avoid null
    }
}
