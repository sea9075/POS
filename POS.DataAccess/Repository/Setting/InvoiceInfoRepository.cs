using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class InvoiceInfoRepository : Repository<InvoiceInfo>, IInvoiceInfoRepository
    {
        private ApplicationDbContext _db;
        public InvoiceInfoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(InvoiceInfo invoiceInfo)
        {
            _db.InvoiceInfo.Update(invoiceInfo);
        }
    }
}
