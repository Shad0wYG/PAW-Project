using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    internal class Visit
    {
        public static int Id = 0;
        public DateTime Timestamp { get; set; }
        public User User { get; set; }

        public Visit() 
        {
            Id++;
            Timestamp = DateTime.Now;
        }

        public Visit(User user)
        {
            Id++;
            User = user;
            Timestamp = DateTime.Now;
        }   
    }
}
