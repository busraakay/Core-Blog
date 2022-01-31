using DataAccsessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.blogCount = c.Blogs.Count().ToString();
            ViewBag.blogByWriterCount = c.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.categoryCount = c.Categories.Count().ToString();
            return View();
        }


    }
}
