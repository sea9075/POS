using Microsoft.AspNetCore.Mvc;
using POS.DataAccess.IRepository;
using POS.Models.Setting;

namespace POS.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class FunctionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FunctionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Function function = new Function();

            if (id == 0 || id == null)
            {
                return View(function);
            }
            else
            {
                function = await _unitOfWork.Function.GetAsync(u => u.FunctionId == id);
                return View(function);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Function function)
        {
            if (ModelState.IsValid)
            {
                function.Timeset = DateTime.Now;

                _unitOfWork.Function.Add(function);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index", new { id = function.FunctionId });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            var functionDeleted = await _unitOfWork.Function.GetAsync(u => u.FunctionId == id);

            if (functionDeleted != null)
            {
                _unitOfWork.Function.Remove(functionDeleted);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Function function)
        {
            if (ModelState.IsValid)
            {
                function.Timeset = DateTime.Now;
                _unitOfWork.Function.Update(function);
                await _unitOfWork.SaveAsync();
                return RedirectToAction("Index", new { id = function.FunctionId });
            }
            else
            {
                return RedirectToAction("Index", new { id = function.FunctionId });
            }
        }

        #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Function> functionListJson = (await _unitOfWork.Function.GetAllAsync()).ToList();
            return Json(new { data = functionListJson });
        }
        #endregion
    }
}
