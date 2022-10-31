using Microsoft.AspNetCore.Mvc;

namespace My_ASpNetCoreApp.Web.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            var productList = new List<Product>()
            {
                new() {Id=1, Name="Kalem"},
                new() {Id=2, Name="Defter"},
                new() {Id=3, Name="Silgi"},


            };
            ViewBag.name = "Asp.Net Core";

            TempData["surname"] = "GUN";

            ViewData["names"] = new List<string>() { "Ahmet", "Mehmet", "Hasan" };

            ViewData["age"] = 30;

            ViewBag.person = new { Id = 1, name = "İbrahim GÜN", age = 39 };

            return View(productList);
        }

        public IActionResult Index2()
        {
            var surName = TempData["surname"];
            return View();
        }

        public IActionResult Index3()
        {
            //veri tabanına kaydetme işlemi
            return RedirectToAction("Index","Ornek");
        
        }
        
        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public IActionResult ParametreView(int id)
        {

            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });

        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }
    }
}
