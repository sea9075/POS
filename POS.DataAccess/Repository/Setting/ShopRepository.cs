using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class ShopRepository : Repository<Shop>, IShopRepository
    {
        private ApplicationDbContext _db;
        public ShopRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Shop shop)
        {
            _db.Shop.Update(shop);
        }
    }
}
