using Anime.Model;
using Anime.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Anime.Data
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        
        

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task AddToCart(Cart item)
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            if (cart == null)
            {
                cart = new List<Cart>();
            }

            var sameItem = cart
                .Find(x => x.Id == item.Id );
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
               
            }

            await _localStorage.SetItemAsync("cart", cart);

            
           

            
        }

        public async Task<List<Cart>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            if (cart == null)
            {
                return new List<Cart>();
            }
            return cart;
        }

        public async Task DeleteItem(Cart item)
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.Id == item.Id);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            
        }

    }
}
