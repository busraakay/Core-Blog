using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreProject.Models;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;

            Context c = new Context();

            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;

            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult PartialWriterNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialWriterFooter()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var userMail = User.Identity.Name;
            Context c = new Context();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();

            var writervalues = wm.TGetById(writerID);
            return View(writervalues);
        }

        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wv = new WriterValidator();

            ValidationResult results = wv.Validate(p);

            if (results.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");  
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

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();

            if(p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;

            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;

            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
