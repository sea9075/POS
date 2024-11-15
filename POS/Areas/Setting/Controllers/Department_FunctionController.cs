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

        public async Task<IActionResult> Index(int? id)
        {
            Department_FunctionViewModel department_FunctionVM = new()
            {
                Department_Function = new Department_Function(),
                Department_FunctionList = (await _unitOfWork.Department_Function.GetAllAsync(u => u.DepartmentId == id, includeProperties: "Function,Department")).ToList(),
                DepartmentList = (await _unitOfWork.Department.GetAllAsync()).ToList(),
            };

            return View(department_FunctionVM);
        }

        [HttpPost]
        public async Task<IActionResult> Permission(List<Department_Function> Department_FunctionList)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "修改權限失敗";
                return RedirectToAction("Index");
            }

            foreach (var item in Department_FunctionList)
            {
                var existingItem = await _unitOfWork.Department_Function.GetAsync(u => u.DepartmentId == item.DepartmentId && u.FunctionId == item.FunctionId);


                if (existingItem != null)
                {
                    // 將 Function 分類為 Amin 的 IsEable 直接設定為 false
                    // 不讓客戶設定 Admin 的功能
                    var functionGroup = await _unitOfWork.Function.GetAsync(u => u.FunctionId == existingItem.FunctionId);

                    if (functionGroup.Group == Utility.Enum.FunctionGroup.Admin)
                    {
                        existingItem.IsEnable = false;
                        existingItem.Timeset = DateTime.Now;
                        _unitOfWork.Department_Function.Update(existingItem);
                    }
                    else
                    {
                        existingItem.IsEnable = item.IsEnable;
                        existingItem.Timeset = DateTime.Now;
                        _unitOfWork.Department_Function.Update(existingItem);
                    }       
                }
            }
            
            await _unitOfWork.SaveAsync();
            TempData["success"] = "修改權限成功";

            return RedirectToAction("Index", new {id = Department_FunctionList[0].DepartmentId });
        }
    }
}
