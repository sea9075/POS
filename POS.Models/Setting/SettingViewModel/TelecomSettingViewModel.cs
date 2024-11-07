using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace POS.Models.Setting.SettingViewModel
{
    public class TelecomSettingViewModel
    {
        public TelecomSetting TelecomSetting { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ShopList { get; set; }
    }
}
