using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInfiniteScrollGridDemo.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            return RedirectToAction("GetNext");
        }

        public ActionResult GetNext(int? pageNum)
        {
            pageNum = pageNum ?? 0;
            ViewBag.IsEndOfRecords = false;
            if (Request.IsAjaxRequest())
            {
                switch (pageNum.Value)
                    {
                    case 1:
                            return PartialView("_Bio");
                            break;
                    case 2:
                            return PartialView("_Page2");
                            break;
                    case 3:
                            return PartialView("_Page3");
                            break;
                    case 4:
                            return PartialView("_Page4");
                            break;
                    case 5:
                            return PartialView("_Page5");
                            break;
                    default:
                            return PartialView("_Bio");
                            break;
                    }
                
            }
            else
            {

                return View("Index");
            }
        }


    }
}