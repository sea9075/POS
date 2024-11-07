using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static POS.Utility.Enum;

namespace POS.Models.Setting
{
    [Index(nameof(Name), nameof(TaxIDNumber), IsUnique = true)]
    [Index(nameof(RespomsiblePerson))]
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }

        [Required(ErrorMessage = "請輸入店點名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*店點名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入店點電話")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*店點電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "請輸入店點傳真")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*店點傳真")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣傳真號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string Fax { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("店點網站")]
        [Url]
        public string? Url { get; set; }

        [Required(ErrorMessage = "請輸入店點 Email")]
        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("*店點 Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "請輸入發票抬頭")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*發票抬頭")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string InvoiceTitle { get; set; }

        [Required(ErrorMessage = "請輸入統一編號")]
        [Column(TypeName = "nvarchar(8)")]
        [StringLength(8, ErrorMessage = "不能超過 8 字")]
        [DisplayName("*統一編號")]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "請輸入正確的統一編號")]
        public string TaxIDNumber { get; set; }

        [Required(ErrorMessage = "請輸入店點負責人")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*店點負責人")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string RespomsiblePerson { get; set; }

        [Required(ErrorMessage = "請輸入營業時間")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*營業時間")]
        [RegularExpression(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]\-(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$", ErrorMessage = "請輸入營業時間，例 : 10:30-22:00")]
        public string BusinessTime { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("店點群組")]
        public ShopGroup? Group { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("發票種類")]
        public ReceiptKind? InvoiceType { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("銷貨單抬頭")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? SalesOrderTitle { get; set; }

        public DateTime Timeset { get; set; }

        [ValidateNever]
        [DisplayName("*倉庫名稱")]
        public int? StockId { get; set; }

        [ValidateNever]
        public Stock Stock { get; set; }
    }
}
