using GiftStoreApplication.Models;

namespace GiftStoreApplication.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
