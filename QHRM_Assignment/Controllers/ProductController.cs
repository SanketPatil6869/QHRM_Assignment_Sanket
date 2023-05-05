using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OHRM_Sanket_Patil.Models;

namespace OHRM_Sanket_Patil.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDao productDao;

        public ProductController(ProductDao productDao)
        {
            this.productDao = productDao;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            IEnumerable<Product> products = productDao.getAllProducts();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            Product product = productDao.getSingleProduct(id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            try
            {
                productDao.addProduct(p);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
                //return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = productDao.getSingleProduct(id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product p)
        {
            try
            {
                productDao.updateProduct(p);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
                //return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = productDao.getSingleProduct(id);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product p)
        {
            try
            {
                productDao.deleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
