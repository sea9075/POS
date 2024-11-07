using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IInvoiceInfoRepository : IRepository<InvoiceInfo>
    {
        void Update(InvoiceInfo invoiceInfo);
    }
}
