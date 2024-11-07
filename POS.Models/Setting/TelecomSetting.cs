using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(ShortName), nameof(ShopId), IsUnique = true)]
    public class TelecomSetting
    {
        [Key]
        public int TelecomSettingId { get; set; }

        [Required(ErrorMessage = "請輸入系統商編號")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*系統商編號")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "只能輸入英文大小寫和數字")]
        public string ShortName { get; set; }

        [Required(ErrorMessage = "請輸入系統商名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*系統商名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("代收代碼")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "只能輸入英文大小寫和數字")]
        public string? AgentReceiptCode { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        [DisplayName("代收次數毛利公式")]
        public decimal? CountAgentReceiptGrossProfitFormula { get; set; }

        [Column(TypeName = "decimal(7,4)")]
        [DisplayName("代收總金額毛利公式")]
        public decimal? TotalAgentReceiptGrossProfitFormula { get; set; }

        public DateTime Timeset { get; set; }

        [ValidateNever]
        [DisplayName("*對應店點編號")]
        public int ShopId { get; set; }

        [ValidateNever]
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }
    }
}
