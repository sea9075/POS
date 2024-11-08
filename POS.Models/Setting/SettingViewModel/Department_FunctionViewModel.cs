using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace POS.Models.Setting.SettingViewModel
{
    public class Department_FunctionViewModel
    {
        public Department_Function Department_Function { get; set; }

        [ValidateNever]
        public List<Department_Function> Department_FunctionList { get; set; }

        [ValidateNever]
        public List<Department> DepartmentList { get; set; }
    }
}
