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
            /*Available websites and categories
              1. Social media : Tiktok, Instagram, Whatsapp
              2. E-Commerce : Amazon, Etsy, Emag
              3. Statistics : Insse, Statista, TradingEconomics 
             
             */
            switch(webname)
            {
                case "Tiktok":
                case "Instagram":
                case "Whatsapp":
                    Id = 1; break;

                case "Amazon":
                case "Etsy":
                case "Emag":
                    Id = 2; break;

                case "Insse":
                case "Statista":
                case "TradingEconomics":
                    Id = 3; break;

            }
            Visits = new List<Visit>();

        }

    }
}
