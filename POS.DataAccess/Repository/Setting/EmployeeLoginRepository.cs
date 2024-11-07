using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class EmployeeLoginRepository : Repository<EmployeeLogin>, IEmployeeLoginRepository
    {
        private ApplicationDbContext _db;
        public EmployeeLoginRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeLogin employeeLogin)
        {
            _db.EmployeeLogin.Update(employeeLogin);
        }
    }
}
