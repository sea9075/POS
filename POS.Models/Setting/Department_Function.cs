using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models.Setting
{
    [Index(nameof(DepartmentId), nameof(FunctionId), IsUnique = true)]
    [Index(nameof(IsEnable))]
    public class Department_Function
    {
        [ValidateNever]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [ValidateNever]
        public Department Department { get; set; }

        [ValidateNever]
        public int FunctionId { get; set; }

        [ValidateNever]
        [ForeignKey("FunctionId")]
        public Function Function { get; set; }

        [Column(TypeName = "bit")]
        public bool IsEnable { get; set; }

        public DateTime Timeset { get; set; }
    }
}
