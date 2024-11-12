using Microsoft.AspNetCore.Mvc;
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
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string photoPath = Path.Combine(wwwRootPath, @"images\employee\photo");

                    using (var fileStream = new FileStream(Path.Combine(photoPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    employee.Photo = @"\images\employee\photo" + fileName;
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
