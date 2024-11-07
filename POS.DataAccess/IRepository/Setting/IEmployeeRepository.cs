using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        void Update(Employee employee);
    }
}
