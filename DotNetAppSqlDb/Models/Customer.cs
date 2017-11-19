using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int passport_number { get; set; }
        public string phone_number { get; set; }
    }
}