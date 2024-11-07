using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(IP_Address), nameof(Name), IsUnique = true)]
    public class IP_Permission
    {
        [Key]
        public int IP_PermissionId { get; set; }

        [Required(ErrorMessage = "請輸入 IPv4 位置")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*IP 位置")]
        [RegularExpression(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$", ErrorMessage = "請輸入 IPv4 位置，例 : 127.0.0.1")]
        public string IP_Address { get; set; }

        [Required(ErrorMessage = "請輸入連線名稱")]
        [Column(TypeName = "nvarchar(30)")]
        [StringLength(30, ErrorMessage = "不能超過 30 字")]
        [DisplayName("*連線名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        public DateTime Timeset { get; set; }
    }
}
