using AutoMapper;
using MediatR;
 
using Ordering.Application.Features.Orders.Queries.GetGetOrdersByUserName;
using OrderService_Application.Contracts.Persistence; 
using OrderService_Application.Queries.GetOrdersByUserName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService_Application.Features.Orders.Queries.GetGetOrdersByUserName
{
    public class OrdersByUserNameQueryHandler : IRequestHandler<GetOrdersByUserNameQuery, List<OrdersByUserNameVM>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrdersByUserNameQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<List<OrdersByUserNameVM>> Handle(GetOrdersByUserNameQuery request, CancellationToken cancellationToken)
        {
            var Orders = await _orderRepository.GetOrdersByUserName(request.UserName);

            return _mapper.Map<List<OrdersByUserNameVM>>(Orders);
        }
    }
}
