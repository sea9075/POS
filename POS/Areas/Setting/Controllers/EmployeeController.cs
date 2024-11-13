using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using POS.DataAccess.IRepository;
using POS.Models.Setting;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmployeeController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Employee employee = new Employee();

            if (id == null || id == 0 || id == 1)
            {
                return View(employee);
            }
            else
            {
                employee = await _unitOfWork.Employee.GetAsync(u => u.EmployeeId == id);
                return View(employee);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                // 取得靜態資料夾路徑
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                // 如果有上傳圖片
                if (file != null)
                {
                    // 判斷副檔名
                    var allowExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

                    // 取得上傳的文件副檔名，並轉換為小寫
                    string fileExtension = Path.GetExtension(file.FileName).ToLower();

                    // 如果上傳的檔案為照片
                    if (Array.Exists(allowExtensions, ext => ext == fileExtension))
                    {
                        // 將檔名變更為 GUID + 副檔名
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        // 取得照片儲存的路徑
                        string photoPath = Path.Combine(wwwRootPath, @"images\employee\photo");

                        // 複製照片到指定資料夾
                        using (var fileStream = new FileStream(Path.Combine(photoPath, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        // 將照片位置存入資料表中
                        employee.Photo = @"\images\employee\photo\" + fileName;
                    }
                    else
                    {
                        TempData["error"] = "更新失敗，照片只支援 : jpg、jpeg、png、gif 和 bmp 格式";
                        return RedirectToAction("Index");
                    }
                }

                _unitOfWork.Employee.Add(employee);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "新增成功";
                return RedirectToAction("Index", new { id = employee.EmployeeId });
            }
            else
            {
                TempData["error"] = "新增失敗";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                // 取得靜態資料夾路徑
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                // 如果有上傳圖片
                if (file != null)
                {
                    // 判斷副檔名
                    var allowExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

                    // 取得上傳的文件副檔名，並轉換為小寫
                    string fileExtension = Path.GetExtension(file.FileName).ToLower();

                    // 如果上傳的檔案為照片
                    if (Array.Exists(allowExtensions, ext => ext == fileExtension))
                    {
                        // 將檔名變更為 GUID + 副檔名
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        // 取得照片儲存的路徑
                        string photoPath = Path.Combine(wwwRootPath, @"images\employee\photo");

                        // 更新照片
                        // 如果有上傳新照片
                        if (!string.IsNullOrEmpty(employee.Photo))
                        {
                            // 取得舊照片路徑
                            var oldPhotoPath = Path.Combine(wwwRootPath, employee.Photo.TrimStart('\\'));

                            // 刪除舊照片
                            if (System.IO.File.Exists(oldPhotoPath))
                            {
                                System.IO.File.Delete(oldPhotoPath);
                            }
                        }
                        else
                        {
                            TempData["error"] = "更新失敗，照片只支援 : jpg、jpeg、png、gif 和 bmp 格式";
                            return RedirectToAction("Index");
                        }

                        // 複製照片到指定資料夾
                        using (var fileStream = new FileStream(Path.Combine(photoPath, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        // 將照片位置存入資料表中
                        employee.Photo = @"\images\employee\photo" + fileName;
                    }
                }

                _unitOfWork.Employee.Update(employee);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "更新成功";
                return RedirectToAction("Index", new { id = employee.EmployeeId });
            }
            else
            {
                TempData["error"] = "更新失敗";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            var employeeDeleted = await _unitOfWork.Employee.GetAsync(u => u.EmployeeId == id);

            if (employeeDeleted != null)
            {
                if (!string.IsNullOrEmpty(employeeDeleted.Photo))
                {
                    // 取得舊照片路徑
                    var oldPhotoPath = employeeDeleted.Photo;

                    // 刪除舊照片
                    if (System.IO.File.Exists(oldPhotoPath))
                    {
                        System.IO.File.Delete(oldPhotoPath);
                    }
                }
                
                _unitOfWork.Employee.Remove(employeeDeleted);
                await _unitOfWork.SaveAsync();
            }

            return RedirectToAction("Index");
        }

        #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Employee> EmployeeListJson = (await _unitOfWork.Employee.GetAllAsync(u => u.EmployeeId != 1)).ToList();
            return Json(new {data = EmployeeListJson});
        }

        #endregion
    }
}