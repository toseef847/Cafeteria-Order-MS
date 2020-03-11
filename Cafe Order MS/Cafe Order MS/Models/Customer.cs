using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cafe_Order_MS.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafe_Order_MS.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phno { get; set; }
        public string CNIC { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}