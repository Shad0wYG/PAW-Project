using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    [Serializable]
    public class User
    {
        public DateTime DateOfBirth { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }

        public User() 
        {
            DateOfBirth = DateTime.Now;
        }

        public User(DateTime dateOfBirth, string fullName, string userName) : this()
        {
            DateOfBirth = dateOfBirth;
            FullName = fullName;
            UserName = userName;
        }
    }
}
