using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
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
            ProductVM productVM = new()
            {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                //ViewBag.CategoryList = CategoryList;
                //ViewData["CoverTypeList"] = CoverTypeList;
                //Create product
                return View(productVM);
            }
            else
            {
                //Update product

            }

            return View(productVM);
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
