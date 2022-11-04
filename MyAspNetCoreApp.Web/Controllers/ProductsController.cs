using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Helpers;
using MyAspNetCoreApp.Web.Models;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;

        private IHelper _helper;

        private readonly ProductRepository _productRepository;
        public ProductsController(AppDbContext context, IHelper helper)
        {
            //DI Container
            //Dependency Injection Pattern
            _productRepository =new  ProductRepository();
            _helper = helper;
            _context = context;

            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product() { Name = "Kalem 1", Price = 100, Stock = 100, Color = "Blue", Weigth = 50, Height = 40 });
                _context.Products.Add(new Product() { Name = "Kalem 2", Price = 100, Stock = 200, Color = "Yellow", Weigth = 60, Height = 10 });
                _context.Products.Add(new Product() { Name = "Kalem 3", Price = 100, Stock = 300, Color = "Purple", Weigth = 80, Height = 90 });

                _context.SaveChanges();
            }

        }
        public IActionResult Index()
        {
            var text = "Beril";
            
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);

            _context.Products.Remove(product);

            _context.SaveChanges();

            return RedirectToAction("Index");

        }
        [HttpGet]

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]

        public IActionResult Add(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            TempData["status"] = "Ürün Başarıyla Eklendi.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _context.Products.Find(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product updateProduct, int productId)
        {

            updateProduct.Id = productId;
            _context.Products.Update(updateProduct);
            _context.SaveChanges();
            TempData["status"] = "Ürün Başarıyla Güncellendi.";
            return RedirectToAction("Index");
        }
    }
}
