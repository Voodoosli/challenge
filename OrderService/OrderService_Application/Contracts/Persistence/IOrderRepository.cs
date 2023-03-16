﻿using OrderService_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName); 
    }
}
