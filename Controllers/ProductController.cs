using PagedList;
using PaginationMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationMVCApp.Controllers
{
    public class ProductController : Controller
    {
        private MvcTestEntities db = new MvcTestEntities();
        // GET: Product
        public ActionResult Index(int page=1,int pageSize=2)
        {
            List<Product> products = db.Products.ToList();
            PagedList<Product> model = new PagedList<Product>(products, page, pageSize);
            return View(model);
        }
    }
}