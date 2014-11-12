using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyProject.Models;


namespace MyProject.DAL
{
    public class MyProjectInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MyProjectContext>
    {
        protected override void Seed(MyProjectContext context)
        {
        }
    }
}