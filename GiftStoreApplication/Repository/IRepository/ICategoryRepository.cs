using GiftStoreApplication.Models;

namespace GiftStoreApplication.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
