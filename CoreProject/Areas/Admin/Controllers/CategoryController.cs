using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();

        public IActionResult Index(int page = 1)
        {
            var values = cm.TGetList().ToPagedList(page, 7);
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            CategoryValidator cv = new CategoryValidator();

            ValidationResult results = cv.Validate(p);

            var userMail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();

            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetById(id);//tüm satırı alır
            cm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
