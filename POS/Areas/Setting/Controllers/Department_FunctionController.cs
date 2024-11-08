using Microsoft.AspNetCore.Mvc;
using POS.DataAccess.IRepository;
using POS.Models.Setting;
using POS.Models.Setting.SettingViewModel;

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
                Department_FunctionList = (await _unitOfWork.Department_Function.GetAllAsync(includeProperties: "Function,Department")).ToList(),
                DepartmentList = (await _unitOfWork.Department.GetAllAsync()).ToList(),
            };

            return View(department_FunctionVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(List<Department_Function> Department_FunctionList)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            foreach (var item in Department_FunctionList)
            {
                var existingitem = await _unitOfWork.Department_Function.GetAsync(u => u.DepartmentId == item.DepartmentId && u.FunctionId == item.FunctionId);

                
            }

            await _unitOfWork.SaveAsync();

            return RedirectToAction("Index");
        }
    }
}
