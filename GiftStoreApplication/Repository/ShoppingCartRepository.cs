using GiftStoreApplication.Data;
using GiftStoreApplication.Models;
using GiftStoreApplication.Repository.IRepository;
using System.Linq.Expressions;

namespace GiftStoreApplication.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
