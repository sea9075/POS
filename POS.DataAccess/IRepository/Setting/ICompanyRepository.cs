using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
