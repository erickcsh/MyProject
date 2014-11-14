using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyProject.DAL
{
    public class MyProjectContext : DbContext
    {
        public MyProjectContext() : base("MyProjectContext")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}