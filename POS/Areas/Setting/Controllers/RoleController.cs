using Microsoft.AspNetCore.Mvc;
using POS.DataAccess.IRepository;
using POS.Models.Setting;
using POS.Models.Setting.SettingViewModel;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Role role = new Role();

            if (id == null || id == 0 || id == 1)
            {
                return View(role);
            }
            else
            {
                role = await _unitOfWork.Role.GetAsync(u => u.RoleId == id);
                return View(role);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Role role)
        {
            if (ModelState.IsValid)
            {
                role.Timeset = DateTime.Now;

                if (role.RoleId == 0)
                {
                    _unitOfWork.Role.Add(role);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "新增成功";
                    return RedirectToAction("Index", new {id = role.RoleId});
                }
                else
                {
                    TempData["error"] = "新增失敗";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["error"] = "新增失敗";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Role role)
        {
            if (ModelState.IsValid)
            {
                role.Timeset = DateTime.Now;
                _unitOfWork.Role.Update(role);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "更新成功";
                return RedirectToAction("Index", new { id = role.RoleId });
            }
            else
            {
                TempData["error"] = "更新失敗";
                return RedirectToAction("Index", new { id = role.RoleId });
            }
        }

        #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // 忽略 Admin
            List<Role> roleListJson = (await _unitOfWork.Role.GetAllAsync(u => u.RoleId != 1)).ToList();
            return Json(new { data = roleListJson });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            var RoleDeleted = await _unitOfWork.Role.GetAsync(u => u.RoleId == id);

            if (RoleDeleted != null)
            {
                _unitOfWork.Role.Remove(RoleDeleted);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "刪除成功";
                return Json(new { success = true });
            }
            else
            {
                TempData["error"] = "刪除失敗";
                return Json(new { success = false });
            }
        }
        #endregion
    }
}
