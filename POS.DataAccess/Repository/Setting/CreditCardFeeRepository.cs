using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class CreditCardFeeRepository : Repository<CreditCardFee>, ICreditCardFeeRepository
    {
        private ApplicationDbContext _db;
        public CreditCardFeeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CreditCardFee creditCardFee)
        {
            _db.CreditCardFee.Update(creditCardFee);
        }
    }
}
