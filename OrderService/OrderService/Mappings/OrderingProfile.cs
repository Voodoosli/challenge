using AutoMapper;
using Eventbus.Messages.Events;
using OrderService_Application.Commands.CheckoutOrder;
namespace OrderService.Mappings
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, CheckoutEvent>().ReverseMap();
        }
    }
}
