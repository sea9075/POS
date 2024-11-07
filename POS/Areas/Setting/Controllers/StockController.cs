using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.DataAccess.IRepository;
using POS.Models.Setting;
using POS.Models.Setting.SettingViewModel;
using System.Text.Json;

namespace POS.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class StockController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            StockViewModel stockVM = new()
            {
                ShopList = (await _unitOfWork.Shop.GetAllAsync()).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ShopId.ToString()
                }),
                Stock = new Stock()
            };

            if (id == 0 || id == null)
            {
                return View(stockVM);
            }
            else
            {
                stockVM.Stock = await _unitOfWork.Stock.GetAsync(u => u.StockId == id);
                return View(stockVM);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(StockViewModel stockVM)
        {
            if (ModelState.IsValid)
            {
                stockVM.Stock.Timeset = DateTime.Now;

                if (stockVM.Stock.Group == null)
                {
                    stockVM.Stock.Group = 0;
                }

                _unitOfWork.Stock.Add(stockVM.Stock);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index", new {id = stockVM.Stock.StockId});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StockViewModel stockVM)
        {
            if (ModelState.IsValid)
            {
                stockVM.Stock.Timeset = DateTime.Now;
                _unitOfWork.Stock.Update(stockVM.Stock);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index", new { id = stockVM.Stock.StockId });
            }
            else
            {
                return RedirectToAction("Index", new { id = stockVM.Stock.StockId });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            var stockDeleted = await _unitOfWork.Stock.GetAsync(u => u.StockId == id);

            if (stockDeleted != null)
            {
                _unitOfWork.Stock.Remove(stockDeleted);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Stock> stockListJson = (await _unitOfWork.Stock.GetAllAsync()).ToList();
            return Json(new {data = stockListJson});
        }
        #endregion
    }
}
