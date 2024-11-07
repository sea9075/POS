using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private ApplicationDbContext _db;
        public RoleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Role role)
        {
            _db.Role.Update(role);
        }
    }
}
