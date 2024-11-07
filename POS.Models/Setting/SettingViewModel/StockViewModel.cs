using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace POS.Models.Setting.SettingViewModel
{
    public class StockViewModel
    {
        public Stock Stock { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ShopList { get; set; }
    }
}
