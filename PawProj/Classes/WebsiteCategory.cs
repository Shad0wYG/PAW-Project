using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    internal class WebsiteCategory
    {
        public int Id { get; set; }
        public List<Visit> Visits { get; set; }
        public string WebName { get; set; }

        public WebsiteCategory(string webname)
        {
            switch(webname)
            {
                //case TO DO: ASSIGN ID BASED ON NAME
            }
            Visits = new List<Visit>();

        }

    }
}
