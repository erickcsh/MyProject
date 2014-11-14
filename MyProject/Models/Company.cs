using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class Company
    {
        public int ID { get; set; }
        public double Rate { get; set; }
        public int ProjectID { get; set; }
    }
}