using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace truYum.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account


        // GET: Accounts

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if (username == "harshit" && password == "harshit")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                FormsAuthentication.RedirectFromLoginPage(username, true);

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();


        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
