using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class Department_FunctionRepository : Repository<Department_Function>, IDepartment_FunctionRepository
    {
        private ApplicationDbContext _db;
        public Department_FunctionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Department_Function department_Function)
        {
            _db.Department_Function.Update(department_Function);
        }
    }
}
