using DelaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DelaApp.Entity
{
    public class DelaDB : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DelaDB() { }

        public System.Data.Entity.DbSet<DelaApp.Models.Invoice> Invoices { get; set; }
    }
}