using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    public class Util
    {
        public static int findCat(string website)
        {
            switch (website)
            {
                case "Tiktok":
                case "Instagram":
                case "Whatsapp":
                    return 1; break;

                case "Amazon":
                case "Etsy":
                case "Emag":
                    return 2; break;

                case "Insse":
                case "Statista":
                case "TradingEconomics":
                    return 3; break;
                default: return 1; break;
            }
        }

        public static void AddVisit(Visit visit, WebsiteCategory one, WebsiteCategory two, WebsiteCategory three) 
        {
            int c = findCat(visit.WebsiteName);
            switch(c)
            {
                case 1: 
                    one.Visits.Add(visit);
                    break;
                case 2:
                    two.Visits.Add(visit);
                    break;
                case 3: 
                    three.Visits.Add(visit);
                    break;
            }
        }


    }
}
