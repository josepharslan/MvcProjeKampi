using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult MyContent(string mail)
        {
            mail = (string)Session["WriterMail"];
            var writeridinfo = wm.GetWriterByMail(mail);
            var contentvalues = cm.GetListByWriter(writeridinfo.WriterID);
            return View(contentvalues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            var content = new Content { HeadingID = id };
            var heading = hm.GetByID(id);
            ViewBag.headingname = heading.HeadingName;
            return View(content);
        }
        [HttpPost]
        public ActionResult AddContent(Content content)
        {
            content.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            content.ContentStatus = true;
            content.WriterID = (int)Session["WriterID"];
            cm.ContentAdd(content);
            return RedirectToAction("MyContent");
        }
        public ActionResult ToDoList()
        {
            return View();
        }
    }
}