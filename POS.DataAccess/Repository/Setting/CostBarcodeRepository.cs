using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class CostBarcodeRepository : Repository<CostBarcode>, ICostBarcodeRepository
    {
        private ApplicationDbContext _db;
        public CostBarcodeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CostBarcode costBarcode)
        {
            _db.CostBarcode.Update(costBarcode);
        }
    }
}
