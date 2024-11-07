using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace POS.Models.Setting.SettingViewModel
{
    public class ShopSalesTargetViewModel
    {
        public ShopSalesTarget ShopSalesTarget { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ShopList { get; set; }
    }
}
