using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            Context c = new Context();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            
            var values = wm.GetWriterById(writerID);

            return View(values);
        }
    }
}
