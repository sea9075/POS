using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IShopSalesTargetRepository : IRepository<ShopSalesTarget>
    {
        void Update(ShopSalesTarget shopSalesTarget);
    }
}
