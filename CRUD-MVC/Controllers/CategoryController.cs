using CRUD_MVC.Data;
using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        // crear con la bd de datos en google
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            // otro metodo de comentario  ..
            if (obj.Name == obj.Price.ToString())
            {
                ModelState.AddModelError("name", "El nombre es erroneo");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }           
            return View();
            

        }
        public IActionResult Edit(int? id)
        {
            if( id == null || id == 0)
            {
                return NotFound();
            }
            Category? CategoryFromDb = _db.Categories.Find(id);
            if(CategoryFromDb == null)
            {
                return NotFound();
            } 
            return View(CategoryFromDb);

        }

    }

}
