using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(BarcodeType), IsUnique = true)]
    public class CostBarcode
    {
        [Key]
        public int CostBarcodeId { get; set; }

        [Required(ErrorMessage = "請輸入編碼類型")]
        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("*編碼類型")]
        [RegularExpression(@"^[A-Z]$", ErrorMessage = "只能輸入英文大寫")]
        public string BarcodeType { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("編碼公式")]
        [RegularExpression(@"^(\+|\-|\*)[0-9]+$", ErrorMessage = "請以運算符號( + - * )開頭，並加上數字，例 : +1999、*3、-3000")]
        public string? Formula { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("前字1")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Front1 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("前字2")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Front2 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("前字3")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Front3 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字0")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number0 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字1")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number1 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字2")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number2 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字3")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number3 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字4")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number4 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字5")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number5 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字6")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number6 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字7")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number7 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字8")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number8 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("數字9")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Number9 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("後字1")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Back1 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("後字2")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Back2 { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        [StringLength(1, ErrorMessage = "不能超過 1 字")]
        [DisplayName("後字3")]
        [RegularExpression(@"^[A-Z0-9]$", ErrorMessage = "只能輸入英文大寫和數字")]
        public string? Back3 { get; set; }

        public DateTime Timeset { get; set; }
    }
}
