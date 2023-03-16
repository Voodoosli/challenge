﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_Application.Queries
{
    public class OrdersVM
    {
        public string UserName { get; set; }
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
