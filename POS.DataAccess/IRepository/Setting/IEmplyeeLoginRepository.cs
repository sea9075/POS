using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IEmployeeLoginRepository : IRepository<EmployeeLogin>
    {
        void Update(EmployeeLogin employeeLogin);
    }
}
