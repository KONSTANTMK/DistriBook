using DistriBook.DataAccess.Repository.IRepository;
using DistriBook.Models;
using DistriBook.Models.ViewModels;
using DistriBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DistriBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
      
        }

        public IActionResult Index()
        {
            return View();
        }

        //Upsert/////////////////////////////////////////////////

        //GET
        public IActionResult Upsert(int? id)
        {
            CompanyModel company = new();


            if (id == null || id == 0)
            {
                //Create product
                return View(company);
            }
            else
            {
                //Update product
                company = _unitOfWork.Company.GetFirstOrDefault(u=>u.Id==id);
                return View(company);
            }

            
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(CompanyModel obj)
        {
            if (ModelState.IsValid)
            {
                

                if (obj.Id == 0)
                {
                    _unitOfWork.Company.Add(obj);
                    TempData["success"] = "Company created successfully!";
                }
                else
                {
                    _unitOfWork.Company.Update(obj);
                    TempData["success"] = "Company updated successfully!";
                }
               
                _unitOfWork.Save();

                return RedirectToAction("Index");
            }
            return View(obj);
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var companyList = _unitOfWork.Company.GetAll();
            return Json(new { data = companyList });
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            // var categoryFromDb = _db.Categories.Find(id);
            var companyFromDbFirst = _unitOfWork.Company.GetFirstOrDefault(u => u.Id == id);
            // var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (companyFromDbFirst == null)
            {
                return Json(new { success = false, message = "Error while deleting"}) ;
            }
            
            _unitOfWork.Company.Remove(companyFromDbFirst);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successfully" });
            


        }

        #endregion


    }


}
