using POS.DataAccess.IRepository.Setting;

namespace POS.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        ICompanyRepository Company {  get; }
        ICostBarcodeRepository CostBarcode { get; }
        ICreditCardFeeRepository CreditCardFee { get; }
        IDepartment_FunctionRepository Department_Function { get; }
        IDepartmentRepository Department { get; }
        IEmployeeRepository Employee { get; }
        IEmployeeLoginRepository EmployeeLogin { get; }
        IFunctionRepository Function { get; }
        IInvoiceInfoRepository InvoiceInfo { get; }
        IIP_PermissionRepository IP_Permission { get; }
        IRoleRepository Role { get; }
        IShopRepository Shop { get; }
        IShopSalesTargetRepository ShopSalesTarget { get; }
        IStockRepository Stock { get; }
        ITelecomSettingRepository TelecomSetting { get; }
        Task SaveAsync();
    }
}
