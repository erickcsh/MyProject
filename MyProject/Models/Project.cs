﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public enum RateTypes
    {
        PerHour,
        FixAmount
    }

    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime OfferEndDate { get; set; }
        public double Rate { get; set; }
        public bool Prepaid { get; set; }
        public string rateType { get; set; }
        public double Budget { get; set; }
    }
}