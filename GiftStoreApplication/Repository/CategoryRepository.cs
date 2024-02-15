using GiftStoreApplication.Data;
using GiftStoreApplication.Models;
using GiftStoreApplication.Repository.IRepository;
using System.Linq.Expressions;

namespace GiftStoreApplication.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
