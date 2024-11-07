using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class ShopSalesTargetRepository : Repository<ShopSalesTarget>, IShopSalesTargetRepository
    {
        private ApplicationDbContext _db;
        public ShopSalesTargetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShopSalesTarget shopSalesTarget)
        {
            _db.ShopSalesTarget.Update(shopSalesTarget);
        }
    }
}
