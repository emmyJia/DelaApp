using DelaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelaApp.ViewModels
{
    public class CustomersViewModel
    {
        public CustomersViewModel()
        {
            CustomersList = new List<Customer>();
        }
        public List<Customer> CustomersList { get; set; }
    }
}