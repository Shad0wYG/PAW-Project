using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    public class Visit
    {
        public static int Id = 0;
        public DateTime Timestamp { get; set; }
        public User User { get; set; }
        public string WebsiteName { get; set; }

        public Visit() 
        {
            Timestamp = DateTime.Now;
        }

        public Visit(User user, string websiteName) : this() 
        {
            Id++;
            User = user;
            WebsiteName = websiteName;
            Timestamp = DateTime.Now;
        }   
    }
}
