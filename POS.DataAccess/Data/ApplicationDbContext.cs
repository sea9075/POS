using Microsoft.EntityFrameworkCore;
using POS.Models.Setting;
using POS.Utility;

namespace POS.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }
        public DbSet<CostBarcode> CostBarcode { get; set; }
        public DbSet<CreditCardFee> CreditCardFee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Department_Function> Department_Function { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLogin> EmployeeLogin { get; set; }
        public DbSet<Function> Function { get; set; }
        public DbSet<InvoiceInfo> InvoiceInfo { get; set; }
        public DbSet<IP_Permission> IP_Permission { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<ShopSalesTarget> ShopSalesTarget { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<TelecomSetting> TelecomSetting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var cryptoPassword = new CryptoPassword();
            var hasPassword = cryptoPassword.HasPassword("284ck6y vmp4");

            modelBuilder.Entity<EmployeeLogin>().HasData(
                new EmployeeLogin
                {
                    EmployeeLoginId = 1,
                    Account = "Administrator",
                    HashPassword = hasPassword,
                    Timeset = DateTime.Now,
                    EmployeeId = 1,
                    DepartmentId = 1,
                    RoleId = 1,
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Admin",
                    ID_Number = "*",
                    Cellphone = "*",
                    Address = "*",
                    PermanentAddress = "*",
                    Email = "*",
                    EmerencyContact = "*",
                    EmerencyContactPhone = "*",
                    Education = "*",
                    Timeset = DateTime.Now
                });

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    ShortName = "Admin",
                    Name = "Admin",
                    Timeset = DateTime.Now
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    ShortName = "Admin",
                    Name = "Admin",
                    CanRead = true,
                    CanCreate = true,
                    CanEdit = true,
                    CanDelete = true,
                    CanPrint = true,
                    CanAudit = true,
                    CanReview = true,
                    Timeset = DateTime.Now
                });

            modelBuilder.Entity<Function>().HasData(
                new Function
                {
                    FunctionId = 1,
                    FunctionName = "Company",
                    FunctionChineseName = "總公司 - 基本資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 2,
                    FunctionName = "CostBarcode",
                    FunctionChineseName = "條碼成本編碼",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 3,
                    FunctionName = "CreditCardFee",
                    FunctionChineseName = "信用卡手續費",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 4,
                    FunctionName = "Department",
                    FunctionChineseName = "公司部門資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 5,
                    FunctionName = "Department_Function",
                    FunctionChineseName = "",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 6,
                    FunctionName = "Employee",
                    FunctionChineseName = "員工基本資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 7,
                    FunctionName = "EmployeeLogin",
                    FunctionChineseName = "員工登入資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 8,
                    FunctionName = "Function",
                    FunctionChineseName = "程式功能",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 9,
                    FunctionName = "InvoiceInfo",
                    FunctionChineseName = "公司發票資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 10,
                    FunctionName = "IP_Permission",
                    FunctionChineseName = "系統 IP 權限設定",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 11,
                    FunctionName = "Role",
                    FunctionChineseName = "群組資料設定",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 12,
                    FunctionName = "Shop",
                    FunctionChineseName = "各店點 - 基本資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 13,
                    FunctionName = "ShopSalesTarget",
                    FunctionChineseName = "各店點 - 目標設定",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 14,
                    FunctionName = "Stock",
                    FunctionChineseName = "各倉庫 - 基本資料",
                    Timeset = DateTime.Now
                },
                new Function
                {
                    FunctionId = 15,
                    FunctionName = "TelecomSetting",
                    FunctionChineseName = "門號系統商設定",
                    Timeset = DateTime.Now
                });

            modelBuilder.Entity<Department_Function>().HasKey(df => new { df.DepartmentId, df.FunctionId });

            modelBuilder.Entity<Department_Function>().HasData(
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 1,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 2,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 3,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 4,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 5,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 6,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 7,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 8,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 9,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 10,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 11,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 12,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 13,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 14,
                    IsEnable = true,
                    Timeset = DateTime.Now
                },
                new Department_Function
                {
                    DepartmentId = 1,
                    FunctionId = 15,
                    IsEnable = true,
                    Timeset = DateTime.Now
                });
        }
    }
}
