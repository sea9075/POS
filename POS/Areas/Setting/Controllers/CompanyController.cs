using Microsoft.AspNetCore.Mvc;
using POS.DataAccess.IRepository;
using POS.Models.Setting;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (await _unitOfWork.Company.AnyAsync(u => u.CompanyId == id) == false)
            {
                Company company = new Company();
                return View(company);
            }
            else
            {
                Company company = await _unitOfWork.Company.GetAsync(u => u.CompanyId == 1);
                return View(company);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(Company company)
        {
            if (ModelState.IsValid)
            {
                if (company.CompanyId != 1)
                {
                    company.Timeset = DateTime.Now;
                    _unitOfWork.Company.Add(company);
                    TempData["success"] = "新增成功";
                }
                else
                {
                    company.Timeset = DateTime.Now;
                    _unitOfWork.Company.Update(company);
                    TempData["success"] = "更新成功";
                }

                await _unitOfWork.SaveAsync();

                return RedirectToAction("Index");
            }
            else
            {
                if (company.CompanyId != 1)
                {
                    TempData["error"] = "新增失敗";
                }
                else
                {
                    TempData["error"] = "更新失敗";
                }

                return View(company);
            }
        }
    }
}
