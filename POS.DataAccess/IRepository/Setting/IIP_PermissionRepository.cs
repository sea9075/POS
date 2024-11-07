using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IIP_PermissionRepository : IRepository<IP_Permission>
    {
        void Update(IP_Permission iP_Permission);
    }
}
