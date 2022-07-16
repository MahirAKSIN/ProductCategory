using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCategori.ViewComponents.Category
{
    public class CmbCategory:ViewComponent
    {

        CategoryManager categoryManager = new CategoryManager(new EfCoreCategoryRepository());

        NorthwindContext db = new NorthwindContext();
        public IViewComponentResult Invoke()
        {
                      

            var val = categoryManager.GetList();


            return View(val);


        }
    }
}
