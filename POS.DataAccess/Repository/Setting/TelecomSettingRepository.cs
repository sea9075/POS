using POS.DataAccess.Data;
using POS.DataAccess.IRepository.Setting;
using POS.Models.Setting;

namespace POS.DataAccess.Repository.Setting
{
    public class TelecomSettingRepository : Repository<TelecomSetting>, ITelecomSettingRepository
    {
        private ApplicationDbContext _db;
        public TelecomSettingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TelecomSetting telecomSetting)
        {
            _db.TelecomSetting.Update(telecomSetting);
        }
    }
}
