using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using RSVP_Project.Models;

namespace RSVP_Project.Database
{
    public class Database
    {
        private SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<EventItem>().Wait();
            _database.CreateTableAsync<RSVP>().Wait();
        }

        public void AddUser(User user)
        {
            _database.InsertAsync(user);
        }

        public void AddEvent(EventItem eventItem)
        {
            _database.InsertAsync(eventItem);
        }
        public void AddRSVP(RSVP rsvp)
        {
            _database.InsertAsync(rsvp);
        }
        public User Login(string username, string password)
        {
            var user = _database.Table<User>().Where(u => u.Username == username && u.Password == password).FirstOrDefaultAsync().Result;
            return user;
        }
        public List<EventItem> GetEvents()
        {
            return _database.Table<EventItem>().ToListAsync().Result;
        }
    }
}
