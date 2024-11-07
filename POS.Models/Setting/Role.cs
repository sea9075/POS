using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(ShortName), nameof(Name), IsUnique = true)]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "請輸入群組編號")]
        [Column(TypeName = "nvarchar(5)")]
        [StringLength(5, ErrorMessage = "不能超過 5 字")]
        [DisplayName("*群組編號")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string ShortName { get; set; }

        [Required(ErrorMessage = "請輸入群組名稱")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*群組名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許查詢")]
        public bool CanRead { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許新增")]
        public bool CanCreate { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許修改")]
        public bool CanEdit { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許刪除")]
        public bool CanDelete { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許列印")]
        public bool CanPrint { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許稽核")]
        public bool CanAudit { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("允許覆核")]
        public bool CanReview { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("備註")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Note { get; set; }

        public DateTime Timeset { get; set; }
    }
}
