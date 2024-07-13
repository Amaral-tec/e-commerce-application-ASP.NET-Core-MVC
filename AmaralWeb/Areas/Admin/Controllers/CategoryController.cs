using Amaral.DataAccess.Repository.IRepository;
using Amaral.Models;
using Amaral.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmaralWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticData.ROLE_ADMIN)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();

            return View(objCategoryList);
        }

        public IActionResult Upsert(int? id)
        {

            if (id == null || id == 0)
            {
                return View(new Category());
            }
            else
            {
                Category categoryObj = _unitOfWork.Category.Get(u => u.Id == id);
                return View(categoryObj);
            }

        }
        [HttpPost]
        public IActionResult Upsert(Category categoryObj)
        {
            if (ModelState.IsValid)
            {

                if (categoryObj.Id == 0)
                {
                    _unitOfWork.Category.Add(categoryObj);
                }
                else
                {
                    _unitOfWork.Category.Update(categoryObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View(categoryObj);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return Json(new { data = objCategoryList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var categoryToBeDeleted = _unitOfWork.Category.Get(u => u.Id == id);
            if (categoryToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Category.Remove(categoryToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
