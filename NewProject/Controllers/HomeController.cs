using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Mvc;
using StackifyLib;

namespace NewProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //counting metric to get a report on how often this page loads per minute
            StackifyLib.Metrics.Count("Log Reload", "Reloads per minute", autoReportZeroIfNothingReported: true);
            return View();            
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}