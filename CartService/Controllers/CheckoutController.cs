using AutoMapper;
using CartService.Entities;
using CartService.Repositories.Abstract;
using Eventbus.Messages.Events;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace CartService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly IBasketRepository _repository;
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IMapper _mapper;

        public CheckoutController(IBasketRepository repository, IPublishEndpoint publishEndpoint, IMapper mapper)
        {
            _repository = repository;
            _publishEndpoint = publishEndpoint;
            _mapper = mapper;
        }
        [HttpGet("[action]/{userName}", Name = "GetBasket")]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Basket>> GetBasket(string userName)
        {
            var basket = await _repository.GetBasket(userName);
            return Ok(basket ?? new Basket(userName));
        }

        [HttpPost("UpdateBasket")]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Basket>> UpdateBasket([FromBody] Basket basket)
        {
            return Ok(await _repository.UpdateBasket(basket));
        }

        [HttpDelete("[action]/{userName}", Name = "DeleteBasket")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBasket(string userName)
        {
            await _repository.DeleteBasket(userName);
            return Ok();
        }

        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> BasketCheckout([FromBody] BasketCheckout basketCheckout)
        {
           
            var basket = await _repository.GetBasket(basketCheckout.UserName);
            if (basket == null)
            {
                return BadRequest();
            }
           
            var eventMessage = _mapper.Map<CheckoutEvent>(basketCheckout);
            eventMessage.TotalPrice = basket.TotalPrice;
            eventMessage.UserName = basket.UserName;
            await _publishEndpoint.Publish<CheckoutEvent>(eventMessage); 
            await _repository.DeleteBasket(basket.UserName);
            return Accepted();
        }

    }
}
