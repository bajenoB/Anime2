using Anime.Model;

namespace Anime.Data
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Cart item);
        Task<List<Cart>> GetCartItems();
        Task DeleteItem(Cart item);
        Task EmptyCart();
    }
}
