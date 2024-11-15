using Microsoft.AspNetCore.Mvc;
using POS.DataAccess.IRepository;
using POS.Models.Setting;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Department department = new Department();

            if (id == 0 || id == null || id == 1)
            {
                return View(department);
            }
            else
            {
                department = await _unitOfWork.Department.GetAsync(u => u.DepartmentId == id);
                return View(department);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                department.Timeset = DateTime.Now;
                _unitOfWork.Department.Add(department);
                await _unitOfWork.SaveAsync();

                // 獲取剛剛新增的 DepartmentId，並存入 Department_Function 的 DepartmentId
                List<Function> functionList = (await _unitOfWork.Function.GetAllAsync()).ToList();

                foreach (var function in functionList)
                {
                    Department_Function department_Function = new()
                    {
                        DepartmentId = department.DepartmentId,
                        FunctionId = function.FunctionId,
                        IsEnable = false,
                        Timeset = DateTime.Now,
                    };

                    _unitOfWork.Department_Function.Add(department_Function);
                }

                TempData["success"] = "新增成功";
                await _unitOfWork.SaveAsync();

                return RedirectToAction("Index", new { id = department.DepartmentId });
            }
            else
            {
                TempData["error"] = "新增失敗";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                department.Timeset = DateTime.Now;
                _unitOfWork.Department.Update(department);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "更新成功";
                return RedirectToAction("Index", new { id = department.DepartmentId });
            }
            else
            {
                TempData["error"] = "更新失敗";
                return RedirectToAction("Index", new { id = department.DepartmentId });
            }
        }

        

        #region CALLS API
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Department> departmentListJson = (await _unitOfWork.Department.GetAllAsync(u => u.DepartmentId != 1)).ToList();
            return Json (new {data = departmentListJson});
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            var departmentDeleted = await _unitOfWork.Department.GetAsync(u => u.DepartmentId == id);

            if (departmentDeleted != null)
            {
                // 刪除 Department_Function
                List<Department_Function> department_FunctionListDeleted = (await _unitOfWork.Department_Function.GetAllAsync(u => u.DepartmentId == departmentDeleted.DepartmentId)).ToList();
                _unitOfWork.Department_Function.RemoveRange(department_FunctionListDeleted);

                // 刪除 Department
                _unitOfWork.Department.Remove(departmentDeleted);

                await _unitOfWork.SaveAsync();
                TempData["success"] = "刪除成功";
                return Json(new { success = true });
            }
            else
            {
                TempData["error"] = "刪除失敗";
                return Json(new { success = true });
            }
        }
        #endregion
    }
}
