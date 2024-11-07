using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(ShortName), nameof(Name), IsUnique = true)]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "請輸入部門編號")]
        [Column(TypeName = "nvarchar(5)")]
        [StringLength(5, ErrorMessage = "不能超過 5 字")]
        [DisplayName("*部門編號")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string ShortName { get; set; }

        [Required(ErrorMessage = "請輸入部門名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*部門名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("部門電話")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string? Phone { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [StringLength(5, ErrorMessage = "不能超過 5 字")]
        [DisplayName("部門分機")]
        [RegularExpression(@"^[0-9]{1,5}$")]
        public string? Ext { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("部門傳真")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣傳真號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string? Fax { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("部門地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Address { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("部門網址")]
        [Url]
        public string? Url { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("備註")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Note { get; set; }

        public DateTime Timeset { get; set; }
    }
}
