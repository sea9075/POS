using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static POS.Utility.Enum;

namespace POS.Models.Setting
{
    [Index(nameof(Name), nameof(ID_Number), IsUnique = true)]
    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("已婚")]
        public bool IsMarried { get; set; }

        [Required(ErrorMessage = "請輸入姓名")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*員工姓名")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入身份證號碼")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*身份證號碼")]
        [RegularExpression(@"^[A-Z]{1}[1-2]{1}[0-9]{8}$", ErrorMessage = "身份證號碼格式錯誤，開頭英文需大寫")]
        public string ID_Number { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("電話號碼")]
        [RegularExpression(@"^(0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4}$", ErrorMessage = "請輸入台灣市話號碼，例 : 033370723、(03)3370723、03-3370723、03-3370723 或 (03)337-0723")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "請輸入手機號碼")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*手機號碼")]
        [RegularExpression(@"^09[0-9]{2}-?[0-9]{3}-?[0-9]{3}$")]
        public string Cellphone { get; set; }

        [Required(ErrorMessage = "請輸入聯絡地址")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("*聯絡地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Address { get; set; }

        [Required(ErrorMessage = "請輸入戶籍地址")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("*戶籍地址")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string PermanentAddress { get; set; }

        [Required(ErrorMessage = "請輸入 Email")]
        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "不能超過 255 字")]
        [DisplayName("*Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "請輸入緊急聯絡人姓名")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "不能超過 10 字")]
        [DisplayName("*緊急聯絡人姓名")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string EmerencyContact { get; set; }

        [Required(ErrorMessage = "請輸入緊急聯絡人電話")]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "不能超過 15 字")]
        [DisplayName("*緊急聯絡人電話")]
        [RegularExpression(@"^((0\d{1,2}-?|\(0\d{1,2}\))\d{3,4}-?\d{4})|(09[0-9]{2}-?[0-9]{3}-?[0-9]{3})$", ErrorMessage = "請輸入台灣市話格式或手機格式，例 : 03-3370723 或 0911-111-111")]
        public string EmerencyContactPhone { get; set; }

        [Required(ErrorMessage = "請輸入最高學歷")]
        [Column(TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "不能超過 20 字")]
        [DisplayName("*最高學歷")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string Education { get; set; }

        [Required(ErrorMessage = "請輸入入職日期")]
        [DisplayName("*入職日期")]
        public DateTime StartDate { get; set; }

        [DisplayName("離職日期")]
        public DateTime? EndDate { get; set; }

        [DisplayName("生日")]
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("性別")]
        public Gender? Gender { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [DisplayName("員工照片")]
        public string? Photo { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("特殊專長")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Skill { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "不能超過 100 字")]
        [DisplayName("備註")]
        [RegularExpression(@"^(?!.*[\s.,，、；;。！？\r\n]{2})[a-zA-Z0-9\u4e00-\u9fa5\s.,，、；;。！？\r\n]*$", ErrorMessage = "僅能輸入中文、英文、數字、基本標點符號、空白和換行，且符號、空白和換行不能連續")]
        public string? Note { get; set; }

        [DisplayName("業績目標")]
        public int? SalesTarget { get; set; }

        [DisplayName("毛利目標")]
        public int? GrossProfit { get; set; }

        public DateTime Timeset { get; set; }
    }
}
