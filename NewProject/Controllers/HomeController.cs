using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Serilog; // access to LoggerConfiguration()
using Serilog.Events; //access to LogEventLevel

namespace NewProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var stackifyLogger = new LoggerConfiguration()
                .WriteTo.Stackify(restrictedToMinimumLevel: LogEventLevel.Information)
                .CreateLogger();
            stackifyLogger.Information("-Serilog-Info-About");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var stackifyLogger = new LoggerConfiguration()
                .WriteTo.Stackify(restrictedToMinimumLevel: LogEventLevel.Fatal)
                .CreateLogger();
            stackifyLogger.Information("-Serilog-Fatal-Contact");
            return View();
        }
    }
}