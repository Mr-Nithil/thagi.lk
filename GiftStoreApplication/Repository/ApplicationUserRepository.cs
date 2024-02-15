using GiftStoreApplication.Data;
using GiftStoreApplication.Models;
using GiftStoreApplication.Repository.IRepository;
using System.Linq.Expressions;

namespace GiftStoreApplication.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
