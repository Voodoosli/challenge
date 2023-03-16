using AutoMapper;
using OrderService_Application.Commands.CheckoutOrder;
using OrderService_Application.Commands.UpdateOrder;
using OrderService_Application.Queries; 
using OrderService_Domain.Entities;
 

namespace OrderService_Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVM>().ReverseMap(); 
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
