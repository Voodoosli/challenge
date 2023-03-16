using MediatR;
 
using OrderService_Application.Queries.GetOrdersByUserName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Queries.GetGetOrdersByUserName
{
    public class GetOrdersByUserNameQuery : IRequest<List<OrdersByUserNameVM>>
    {
        public string UserName { get; set; }

        public GetOrdersByUserNameQuery(string userName)
        {
            UserName = userName;
        }
    }
}
