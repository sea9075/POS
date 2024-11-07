using Microsoft.AspNetCore.Mvc.Rendering;

namespace POS.Models.Setting.SettingViewModel
{
    public class ShopViewModel
    {
        public Shop Shop { get; set; }

        public IEnumerable<SelectListItem> StockList { get; set; }
    }
}
