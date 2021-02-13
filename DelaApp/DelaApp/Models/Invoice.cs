using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelaApp.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string Folio { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int Percentage { get; set; }
    }
}