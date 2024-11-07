using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IRoleRepository : IRepository<Role>
    {
        void Update(Role role);
    }
}
