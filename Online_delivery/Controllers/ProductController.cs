using Online_delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_delivery.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private StoreContext _context;
        public ProductController()
        {
            _context = new StoreContext();
        }
        public ActionResult CreateProduct()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("ListProduct");
        }

        public ActionResult ListProduct()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public ActionResult Editproduct()
        {
            return View();
        }
        public ActionResult DeleteProduct()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
    

}