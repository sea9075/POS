using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(TaxIDNumber), nameof(BusinessName), IsUnique = true)]
    public class InvoiceInfo
    {
        [Key]
        public int InvoiceInfoId { get; set; }

        [Required(ErrorMessage = "請輸入統一編號")]
        [Column(TypeName = "nvarchar(8)")]
        [StringLength(8, ErrorMessage = "不能超過 8 字")]
        [RegularExpression(@"^[0,9]{8}$", ErrorMessage = "統一編號格式錯誤")]
        [DisplayName("*統一編號")]
        public string TaxIDNumber { get; set; }

        [Required(ErrorMessage = "請輸入發票公司名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*發票公司名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string BusinessName { get; set; }

        [Required(ErrorMessage = "請輸入公司電話")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*公司電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "請輸入發票地址")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("*發票地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string TaxAddress { get; set; }

        public DateTime Timeset { get; set; }
    }
}
