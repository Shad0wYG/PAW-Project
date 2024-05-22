﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProj.Classes
{
    [Serializable]
    public class WebsiteCategory
    {
        public int Id { get; set; }
        public List<Visit> Visits { get; set; }

        public WebsiteCategory(int id) 
        {
            Id = id; 
            Visits = new List<Visit>();
        }

        //public void addVisit(Visit visit)
        //{
        //    //Id = Util.findCat(visit.WebsiteName);
        //    Visits.Add(visit);
        //}




    }
}

    