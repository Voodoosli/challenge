using AutoMapper;
using CartService.Entities;
using Eventbus.Messages.Events;

namespace CartService.Mapper
{
    public class CheckoutMap : Profile
    {
      
            public CheckoutMap()
            {
                CreateMap<BasketCheckout, CheckoutEvent>().ReverseMap();
            }
       
    }
}
