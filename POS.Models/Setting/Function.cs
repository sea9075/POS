using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static POS.Utility.Enum;

namespace POS.Models.Setting
{
    [Index(nameof(FunctionName), IsUnique = true)]
    public class Function
    {
        [Key]
        public int FunctionId { get; set; }

        [Required(ErrorMessage = "請輸入功能名稱")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "不能超過 50 字")]
        [DisplayName("*功能名稱")]
        public string FunctionName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "不能超過 50 字")]
        [DisplayName("功能中文名稱")]
        public string? FunctionChineseName { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("功能分類")]
        public FunctionGroup Group { get; set; }

        public DateTime Timeset { get; set; }
    }
}
