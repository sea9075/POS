using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(CreditCardFeeName), IsUnique = true)]
    public class CreditCardFee
    {
        [Key]
        public int CreditCardFeeId { get; set; }

        [Required(ErrorMessage = "請輸入信用卡名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*卡別名稱")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string CreditCardFeeName { get; set; }

        [Required(ErrorMessage = "請輸入手續費")]
        [Column(TypeName = "decimal(5,4)")]
        [Range(0, 9, ErrorMessage = "手續費必須在 0.0000 到 9.0000 %")]
        [DisplayName("*手續費(%)")]
        public decimal Fee { get; set; }

        public DateTime Timeset { get; set; }
    }
}
