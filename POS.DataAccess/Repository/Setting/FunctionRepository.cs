using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class FunctionRepository : Repository<Function>, IFunctionRepository
    {
        private ApplicationDbContext _db;
        public FunctionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Function function)
        {
            _db.Function.Update(function);
        }
    }
}
