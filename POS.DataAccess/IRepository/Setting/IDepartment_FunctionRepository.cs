using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IDepartment_FunctionRepository : IRepository<Department_Function>
    {
        void Update(Department_Function department_Function);
    }
}
