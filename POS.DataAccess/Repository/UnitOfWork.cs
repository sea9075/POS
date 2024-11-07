using POS.DataAccess.Data;
using POS.DataAccess.IRepository;
using POS.DataAccess.IRepository.Setting;
using POS.DataAccess.Repository.Setting;

namespace POS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public ICompanyRepository Company {  get; private set; }
        public ICostBarcodeRepository CostBarcode { get; private set; }
        public ICreditCardFeeRepository CreditCardFee { get; private set; }
        public IDepartment_FunctionRepository Department_Function { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public IEmployeeRepository Employee { get; private set; }
        public IEmployeeLoginRepository EmployeeLogin { get; private set; }
        public IFunctionRepository Function { get; private set; }
        public IInvoiceInfoRepository InvoiceInfo { get; private set; }
        public IIP_PermissionRepository IP_Permission { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IShopRepository Shop { get; private set; }
        public IShopSalesTargetRepository ShopSalesTarget { get; private set; }
        public IStockRepository Stock { get; private set; }
        public ITelecomSettingRepository TelecomSetting { get; private set; }
        

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            Company = new CompanyRepository(_db);
            CostBarcode = new CostBarcodeRepository(_db);
            CreditCardFee = new CreditCardFeeRepository(_db);
            Department_Function = new Department_FunctionRepository(_db);
            Department = new DepartmentRepository(_db);
            Employee = new EmployeeRepository(_db);
            EmployeeLogin = new EmployeeLoginRepository(_db);
            Function = new FunctionRepository(_db);
            InvoiceInfo = new InvoiceInfoRepository(_db);
            IP_Permission = new IP_PermissionRepository(_db);
            Role = new RoleRepository(_db);
            Shop = new ShopRepository(_db);
            ShopSalesTarget = new ShopSalesTargetRepository(_db);
            Stock = new StockRepository(_db);
            TelecomSetting = new TelecomSettingRepository(_db);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
