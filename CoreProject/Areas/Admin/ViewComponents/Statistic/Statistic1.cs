using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            string apiKey = "84450326158b347fa6e39d0c4b5b6ad2";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Kocaeli&mode=xml&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(connection);
            ViewBag.temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            string icon = document.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            ViewBag.icon = "http://openweathermap.org/img/w/" + icon + ".png";
            return View();
        }
    }
}
