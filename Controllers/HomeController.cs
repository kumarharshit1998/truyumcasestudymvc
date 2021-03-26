using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace truYum.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        // log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));  //Declaring Log4Net  
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
           logger.Error("Login-page started...");
            try
            {
                int x, y, z;
                x = 5; y = 0;
                z = x / y;
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}