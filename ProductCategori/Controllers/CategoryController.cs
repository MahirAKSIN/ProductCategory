using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCategori.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCoreCategoryRepository());
        ProductManager productManager = new ProductManager(new EfCoreProductRepository());

        NorthwindContext db = new NorthwindContext();
        public IActionResult Index(int id)
        {
            var category = categoryManager.TGetById(id);
            List<SelectListItem> selectListItems = (from i in db.Kategorilers.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = i.KategoriAdi,
                                                        Value = i.KategoriId.ToString()
                                                    }).ToList();
            ViewBag.select = selectListItems;
            return View(category);

        }
        [HttpGet]
        public IActionResult CategorySel()
        {
            var category = categoryManager.GetList();

            return View(category);

        }
        public IActionResult ProductList()
        {
            var product=productManager.GetList();
            return View(product);


        }


    }
}
