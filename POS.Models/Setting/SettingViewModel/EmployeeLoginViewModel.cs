using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace POS.Models.Setting.SettingViewModel
{
    public class EmployeeLoginViewModel
    {
        public EmployeeLogin EmployeeLogin { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}
