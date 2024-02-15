using GiftStoreApplication.Data;
using GiftStoreApplication.Models;
using GiftStoreApplication.Repository.IRepository;
using System.Linq.Expressions;

namespace GiftStoreApplication.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
