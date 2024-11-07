using Microsoft.AspNetCore.Mvc;
using POS.Models.Setting.SettingViewModel;
using POS.Models.Setting;
using POS.DataAccess.IRepository;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class Department_FunctionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public Department_FunctionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            Department_FunctionViewModel department_FunctionVM = new()
            {
                Department_Function = new Department_Function(),
                DepartmentList = (await _unitOfWork.Department.GetAllAsync()).ToList(),
                FunctionList = new List<Function>()
            };

            return View(department_FunctionVM);
        }
    }
}
