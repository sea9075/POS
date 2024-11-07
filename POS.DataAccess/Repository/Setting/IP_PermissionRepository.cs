using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class IP_PermissionRepository : Repository<IP_Permission>, IIP_PermissionRepository
    {
        private ApplicationDbContext _db;
        public IP_PermissionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(IP_Permission iP_Permission)
        {
            _db.IP_Permission.Update(iP_Permission);
        }
    }
}
