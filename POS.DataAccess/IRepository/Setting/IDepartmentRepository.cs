using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        void Update(Department department);
    }
}
