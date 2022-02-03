using DataAccsessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlog = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    
    }
}
