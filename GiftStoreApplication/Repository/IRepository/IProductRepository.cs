using GiftStoreApplication.Models;

namespace GiftStoreApplication.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
