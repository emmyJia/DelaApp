using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DelaApp.Entity;
using DelaApp.Models;

namespace DelaApp.Service
{
    public static class Customers
    {
        public static List<Customer> GetAllCustomers()
        {
            var list = new List<Models.Customer>();
            using (var context = new DelaDB())
            {
                list = (from c in context.Customers
                            select c).ToList();
            }
            
            return list;
        }
    }
}