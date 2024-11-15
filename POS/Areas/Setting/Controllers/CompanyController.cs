﻿using Microsoft.AspNetCore.Mvc;
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
            Company company = await _unitOfWork.Company.GetAsync(u => u.CompanyId == 1);

            if (company == null)
            {
                company = new Company();
                return View(company);
            }
            else
            {
                return View(company);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(Company company)
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

                return RedirectToAction("Index", new {id = 1});
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
