using OrderService_Domain.Common;
using OrderService_Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_Domain.Entities
{
    public class Order : EntityBase
    { 
        public string UserName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Exp { get; set; }
        public string cvv { get; set; }
        public int PaymentMethod { get; set; }
    }
}
