using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.DataAccess.IRepository;
using POS.Models.Setting;
using POS.Models.Setting.SettingViewModel;

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
                if (stockVM.Stock.StockId == 0 || stockVM.Stock.StockId == null)
                {
                    stockVM.Stock.Timeset = DateTime.Now;

                    if (stockVM.Stock.Group == null)
                    {
                        stockVM.Stock.Group = 0;
                    }

                    _unitOfWork.Stock.Add(stockVM.Stock);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "新增成功";

                    return RedirectToAction("Index", new { id = stockVM.Stock.StockId });
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
        public async Task<IActionResult> Edit(StockViewModel stockVM)
        {
            if (ModelState.IsValid)
            {
                stockVM.Stock.Timeset = DateTime.Now;
                _unitOfWork.Stock.Update(stockVM.Stock);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "更新成功";
                return RedirectToAction("Index", new { id = stockVM.Stock.StockId });
            }
            else
            {
                TempData["error"] = "更新失敗";
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
                TempData["success"] = "刪除成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "刪除失敗";
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
