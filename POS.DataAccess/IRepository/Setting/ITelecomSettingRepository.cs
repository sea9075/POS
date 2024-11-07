using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface ITelecomSettingRepository : IRepository<TelecomSetting>
    {
        void Update(TelecomSetting telecomSetting);
    }
}
