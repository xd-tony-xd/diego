using CRUD_MVC.Data;
using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _db.Products.ToList();
            return View(objProductList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (obj.Name == obj.Price.ToString())
            {
                ModelState.AddModelError("name", "El nombre no puede ser igual al precio.");
            }

            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}