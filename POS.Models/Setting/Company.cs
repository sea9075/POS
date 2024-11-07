using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }


        [Required(ErrorMessage = "請輸入公司名稱")]
        [Column(TypeName = "nvarchar(30)")]
        [StringLength(30, ErrorMessage = "不能超過 30 字")]
        [DisplayName("*公司名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入公司電話")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*公司電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033386233、(03)3386233、03-3386233、03-3386233 或 (03)338-6233")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "請輸入傳真電話")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*傳真電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣傳真號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string Fax { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("公司網站")]
        [Url(ErrorMessage = "請輸入正確的網址格式，例 : https://www.sgw.com.tw")]
        public string? Url { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("公司 Email")]
        [EmailAddress(ErrorMessage = "請輸入正確的 Email 格式，例 : service@sgw.com.tw")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "請輸入公司地址")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("*公司地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Address { get; set; }

        [Required(ErrorMessage = "請輸入發票地址")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("*發票地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string TaxAddress { get; set; }

        [ValidateNever]
        public DateTime Timeset { get; set; }
    }
}
