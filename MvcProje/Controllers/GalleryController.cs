using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager fm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = fm.GetList();
            return View(files);
        }
    }
}