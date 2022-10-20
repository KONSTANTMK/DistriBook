using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductModel> objProductList = _unitOfWork.Product.GetAll();

            return View(objProductList);
        }

        //CREATE/////////////////////////////////////////////////

        //GET


        //Upsert/////////////////////////////////////////////////

        //GET
        public IActionResult Upsert(int? id)
        {
            ProductModel product = new();
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString(),
                });
            IEnumerable<SelectListItem> CoverTypeList= _unitOfWork.CoverType.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString(),
                });

            ViewBag.CategoryList = CategoryList;
            ViewBag.CoverTypeList = CoverTypeList;

            if (id == null || id == 0)
            {
                //Create product
                return View(product);
            }
            else
            {
                //Update product

            }

            return View(product);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(ProductModel obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category successfully edited!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //DELETE/////////////////////////////////////////////////

        //GET

        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            // var categoryFromDb = _db.Categories.Find(id);
            var productFromDbFirst = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            // var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (productFromDbFirst == null)
            {
                return NotFound();
            }
            return View(productFromDbFirst);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePOST(int? id)
        {
            // var categoryFromDb = _db.Categories.Find(id);
            var productFromDbFirst = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            // var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (productFromDbFirst == null)
            {
                return NotFound();
            }

            _unitOfWork.Product.Remove(productFromDbFirst);
            _unitOfWork.Save();
            TempData["success"] = "Category successfully deleted!";
            return RedirectToAction("Index");


        }

    }
}
