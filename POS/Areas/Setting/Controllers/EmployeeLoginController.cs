using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.DataAccess.IRepository;
using POS.Models.Setting;
using POS.Models.Setting.SettingViewModel;
using POS.Utility;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class EmployeeLoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLoginController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            EmployeeLoginViewModel employeeLoginVM = new()
            {
                EmployeeLogin = new EmployeeLogin(),
                EmployeeList = (await _unitOfWork.Employee.GetAllAsync(u => u.EmployeeId != 1)).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.EmployeeId.ToString()
                }),
                DepartmentList = (await _unitOfWork.Department.GetAllAsync(u => u.DepartmentId != 1)).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.DepartmentId.ToString()
                }),
                RoleList = (await _unitOfWork.Role.GetAllAsync(u => u.RoleId != 1)).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.RoleId.ToString()
                })
            };

            if (id == 0 || id == null || id == 1)
            {
                return View(employeeLoginVM);
            }
            else
            {
                employeeLoginVM.EmployeeLogin = await _unitOfWork.EmployeeLogin.GetAsync(u => u.EmployeeLoginId == id);
                return View(employeeLoginVM);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeLoginViewModel employeeLoginVM)
        {
            if (ModelState.IsValid)
            {
                employeeLoginVM.EmployeeLogin.Timeset = DateTime.Now;

                // 密碼加密
                var cryptoPassword = new CryptoPassword();
                var hasPassword = cryptoPassword.HasPassword(employeeLoginVM.EmployeeLogin.HashPassword);
                employeeLoginVM.EmployeeLogin.HashPassword = hasPassword;

                _unitOfWork.EmployeeLogin.Add(employeeLoginVM.EmployeeLogin);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "新增成功";
                return RedirectToAction("Index", new { id = employeeLoginVM.EmployeeLogin.EmployeeLoginId });
            }
            else
            {
                TempData["error"] = "新增失敗";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeLoginViewModel employeeLoginVM)
        {
            // 如果沒有變更密碼
            if (employeeLoginVM.EmployeeLogin.HashPassword == null)
            {
                employeeLoginVM.EmployeeLogin.HashPassword = (await _unitOfWork.EmployeeLogin.GetAsync(u => u.EmployeeLoginId == employeeLoginVM.EmployeeLogin.EmployeeLoginId)).HashPassword;
            }

            if (ModelState.IsValid)
            {
                employeeLoginVM.EmployeeLogin.Timeset = DateTime.Now;

                _unitOfWork.EmployeeLogin.Update(employeeLoginVM.EmployeeLogin);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "更新成功";
                return RedirectToAction("Index", new { id = employeeLoginVM.EmployeeLogin.EmployeeLoginId });
            }
            else
            {
                TempData["error"] = "更新失敗";
                return RedirectToAction("Index");
            }
        }


        #region API CALLS
        public async Task<IActionResult> GetAll()
        {
            List<EmployeeLogin> employeeLoginListJson = (await _unitOfWork.EmployeeLogin.GetAllAsync(u => u.EmployeeLoginId != 1, includeProperties: "Employee, Department, Role")).ToList();
            return Json(new { data = employeeLoginListJson });
        }
        #endregion
    }
}
