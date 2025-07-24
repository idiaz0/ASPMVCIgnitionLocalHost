using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Inspinia.Controllers
{
    public class DashboardsController : Controller
    {
        public ActionResult Default() => View();
        public IActionResult Index1() => View();
        public IActionResult Index2() => PartialView();
        public IActionResult Index3() => View();

        public ActionResult API() => PartialView();
        public ActionResult CardTemperature()
        {
            return PartialView("_CardTemperature");
        }

        public IActionResult Operation()
        {
            return PartialView("Operation");
        }

        public ActionResult Assets(string Line, String Asset, int DownTime, int PartsProduced, int Scrap, int OA, int MTTR, String className, String Status)
        {
            ViewBag.Line = Line;
            ViewBag.Asset = Asset;
            ViewBag.OA = OA;
            ViewBag.DownTime = DownTime;
            ViewBag.PartsProduced = PartsProduced;
            ViewBag.Scrap = Scrap;
            ViewBag.MTTR = MTTR;
            ViewBag.ClassName = className;
            ViewBag.Status = Status;
            return PartialView("Assets");
        }



    }


    
}