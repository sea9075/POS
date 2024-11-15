using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(Account), IsUnique = true)]
    public class EmployeeLogin
    {
        [Key]
        public int EmployeeLoginId { get; set; }

        [Required(ErrorMessage = "請輸入登入帳號")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最少輸入 3 字，最多 20 字")]
        [DisplayName("*登入帳號")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "登入帳號只能使用英文大小寫和數字")]
        public string Account { get; set; }

        [Required(ErrorMessage = "請輸入登入密碼")]
        [Column(TypeName = "nvarchar(255)")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "最少輸入 6 字，最多 16 字")]
        [DisplayName("*登入密碼")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "登入密碼只能使用英文大小寫和數字")]
        public string HashPassword { get; set; }

        [ValidateNever]
        [DisplayName("進貨瀏覽限制日期")]
        public DateTime LimitCheckPurchaseDate { get; set; }

        [DisplayName("後台向前編輯天數")]
        public int? LimitEditSalesOrder {  get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255)]
        [DisplayName("可編輯安全庫存")]
        public string? EditSafetyStock { get; set; }

        [ValidateNever]
        public DateTime Timeset {  get; set; }

        [ValidateNever]
        [DisplayName("*員工編號")]
        public int EmployeeId { get; set; }

        [ValidateNever]
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ValidateNever]
        [DisplayName("*部門編號")]
        public int DepartmentId { get; set; }

        [ValidateNever]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [ValidateNever]
        [DisplayName("*群組編號")]
        public int RoleId { get; set; }

        [ValidateNever]
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
