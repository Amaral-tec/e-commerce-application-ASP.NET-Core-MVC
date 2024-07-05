using Amaral.DataAccess.Data;
using Amaral.DataAccess.Repository.IRepository;

namespace Amaral.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
        public ICategoryRepository CategoryRepository { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
