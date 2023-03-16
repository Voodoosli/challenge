using System.Collections.Generic;
using System.Linq;

namespace CartService.Entities
{
    public class Basket
    {
        public string UserName { get; set; } 
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public Basket()
        {

        }

        public Basket(string userName)
        {
            UserName = userName;
        }

        public decimal TotalPrice
        {
            get
            { 
                return Items.Sum(x => x.Price);
            }
        }
    }
}
