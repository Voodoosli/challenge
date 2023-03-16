using CartService.Entities;
using System.Threading.Tasks;

namespace CartService.Repositories.Abstract
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasket(string userName);
        Task<Basket> UpdateBasket(Basket basket);
        Task DeleteBasket(string userName);
    }
}
