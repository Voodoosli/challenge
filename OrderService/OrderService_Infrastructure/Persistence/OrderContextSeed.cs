using Microsoft.Extensions.Logging;
using OrderService_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {
                    UserName = "User1",
                    ProductName = "Product 1",
                    TotalPrice = 11000,
                    FirstName = "Ahmet", 
                    LastName = "Irmak", 
                    Email = "example@example.com", 
                    Address = "Address", 
                    Country = "Turkey", 
                    State = "State", 
                    ZipCode = "ZipCode", 
                    CardName = "CardName", 
                    CardNumber = "0000000000000001", 
                    Exp = "3", 
                    cvv = "000", 
                    PaymentMethod = 2, 
                },
                new Order() {
                    UserName = "User2",
                    ProductName = "Product 2",
                    TotalPrice = 17000,
                    FirstName = "Mehmet",
                    LastName = "Gül",
                    Email = "example@example.com",
                    Address = "Address",
                    Country = "Turkey",
                    State = "State",
                    ZipCode = "ZipCode",
                    CardName = "CardName",
                    CardNumber = "0000000000000001",
                    Exp = "3",
                    cvv = "000",
                    PaymentMethod = 2, }, 
            };
        }
    }
}

