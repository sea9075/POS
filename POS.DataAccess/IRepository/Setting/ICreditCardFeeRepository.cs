using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface ICreditCardFeeRepository : IRepository<CreditCardFee>
    {
        void Update(CreditCardFee creditCardFee);
    }
}
