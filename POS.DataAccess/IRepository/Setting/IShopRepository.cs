using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IShopRepository : IRepository<Shop>
    {
        void Update(Shop shop);
    }
}
