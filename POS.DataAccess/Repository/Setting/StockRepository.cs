using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        private ApplicationDbContext _db;
        public StockRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Stock stock)
        {
            _db.Stock.Update(stock);
        }
    }
}
