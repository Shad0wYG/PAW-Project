using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    [Serializable]
    public class Visit
    {
        public static int Id = 0;
        public DateTime Timestamp { get; set; }
        public string WebsiteName { get; set; }
        public List<User> UserHistory { get; set; }

        public Visit() 
        {
            Timestamp = DateTime.Now;
            UserHistory = new List<User>();
        }

        public Visit(User user, string websiteName) : this() 
        {
            Id++;
            UserHistory.Add(user);
            WebsiteName = websiteName;
            Timestamp = DateTime.Now;
        }   
    }
}
