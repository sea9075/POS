using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface ICostBarcodeRepository : IRepository<CostBarcode>
    {
        void Update(CostBarcode costBarcode);
    }
}
