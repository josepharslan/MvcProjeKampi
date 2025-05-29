using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AdminStatisticsController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.category = c.Categories.Count();
            ViewBag.headingcount = c.Headings.Where(x => x.Category.CategoryName == "Yazılım").Count();
            ViewBag.acount = c.Writers.Count(x => x.WriterName.Contains("a"));
            var maxcategory = c.Categories.Select(x => new
            {
                CategoryName = x.CategoryName,
                HeadingCount = x.Headings.Count()
            })
                .OrderByDescending(x => x.HeadingCount)
                .FirstOrDefault();
            ViewBag.maxcategory = maxcategory.CategoryName;
            int trueCount = c.Categories.Count(x => x.CategoryStatus == true);
            int falseCount = c.Categories.Count(x => x.CategoryStatus == false);
            int difference = trueCount - falseCount;
            ViewBag.categoryDifference = difference;
            return View();
        }

    }
}