using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Cafe_Order_MS.Models;

namespace Cafe_Order_MS.Models
{
    public class Context:DbContext
    {
        public DbSet<Orders> orders { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}