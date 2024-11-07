using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(ShopId), nameof(YearAndMonth), IsUnique = true)]
    public class ShopSalesTarget
    {
        [Key]
        public int ShopSalesTargetId { get; set; }

        [Required(ErrorMessage = "請輸入目標年月")]
        [DisplayName("*年月")]
        public DateTime YearAndMonth { get; set; }

        [DisplayName("營業月目標")]
        public int? MonthlySalesTarget {  get; set; }

        [DisplayName("毛利月目標")]
        public int? MonthlyGrossProfitTarget { get; set; }

        [Required]
        [ValidateNever]
        [DisplayName("*店點名稱")]
        public int ShopId { get; set; }

        [ValidateNever]
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }
    }
}
