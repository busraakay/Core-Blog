using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
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
    }
}
