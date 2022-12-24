using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddingBootstrapTheme.Models
{
    public class PoliceStationContext : DbContext
    {
        public DbSet <Police> Polices { get; set; } // Police table.
        public DbSet<Department> Departments { get; set; }// Department table.

        public DbSet<User> Users { get; set; } // Users table.

        public DbSet<Issue> Issues { get; set; } // Issue table.


    }
}