using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IStockRepository : IRepository<Stock>
    {
        void Update(Stock stock);
    }
}
