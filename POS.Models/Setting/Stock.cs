using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static POS.Utility.Enum;

namespace POS.Models.Setting
{
    [Index(nameof(Name), IsUnique = true)]
    public class Stock
    {
        [Key]
        public int StockId { get; set; }

        [Required(ErrorMessage = "請輸入倉庫名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*倉庫名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("倉庫電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string? Phone { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("傳真電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣傳真號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string? Fax { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("倉庫地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Address { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("倉庫群組")]
        public StockGroup? Group { get; set; }

        [ValidateNever]
        [Column(TypeName = "int")]
        [DisplayName("門市自行發貨店點")]
        public int? ShopId { get; set; }

        [ValidateNever]
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("前台庫存選單")]
        public bool IsShowFront { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("總部庫存選單")]
        public bool IsShowHeadquarters { get; set; }

        [ValidateNever]
        public DateTime Timeset { get; set; }
    }
}
