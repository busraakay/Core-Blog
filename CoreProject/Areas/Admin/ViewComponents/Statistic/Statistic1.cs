using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Areas.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        ContactManager cm = new ContactManager(new EfContactRepository());
        CommentManager com = new CommentManager(new EfCommentRepository());


        public IViewComponentResult Invoke()
        {
            ViewBag.blogCount = bm.TGetList().Count();
            ViewBag.contactCount = cm.TGetList().Count();
            ViewBag.commentCount = com.TGetList().Count();
            return View();
        }
    }
}
