
using CartService.Entities;
using CartService.Repositories.Abstract;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CartService.Repositories.Concrete
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache;
        }

        public async Task DeleteBasket(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }

        public async Task<Basket> GetBasket(string userName)
        {
            var basket = await _redisCache.GetStringAsync(userName);

            if (String.IsNullOrEmpty(basket))
                return null;

            return JsonConvert.DeserializeObject<Basket>(basket);
        }

        public async Task<Basket> UpdateBasket(Basket basket)
        {
            var Expiry = new TimeSpan(0, 0, 30);
            await _redisCache.SetStringAsync(basket.UserName, JsonConvert.SerializeObject(basket), new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(30),
                
            });
            
            return await GetBasket(basket.UserName);
        }
    }
}
