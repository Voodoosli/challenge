using Microsoft.EntityFrameworkCore;
using OrderService_Application.Contracts.Persistence;
using OrderService_Domain.Entities;
using OrderService_Infrastructure.Persistence;
using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace OrderService_Infrastructure.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbContext.Orders
                                    .Where(o => o.UserName == userName)
                                    .ToListAsync();
            return orderList;
        } 
    }
}
