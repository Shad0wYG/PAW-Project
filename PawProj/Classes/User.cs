using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    internal class User
    {
        public int age { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public List<Visit> VisitHistory { get; set; }

    }
}
