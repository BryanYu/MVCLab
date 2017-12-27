using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using OneCenter.BLL.Admin;
using OneCenter.Models.ViewModels.Auth;
using System.Web.Security;

using OneCenter.Resource;
using System.Resources;

namespace OneCenter.Web.Controllers
{
    public class AuthController : Controller
    {
        private AdminService _service;

        public AuthController()
        {
            this._service = new AdminService();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var admin = _service.GetAdmin(viewModel.Account, viewModel.Password);
            var success = admin != null;
            if (success)
            {
                this.LoginProcess(viewModel.Account);
                return RedirectToAction("Index", "Admin");
            }
            return this.View();
        }

        public void LoginProcess(string account)
        {
            var now = DateTime.Now;
            var ticket = new FormsAuthenticationTicket(
                version: 1,
                name: account,
                issueDate: now,
                expiration: now.AddMinutes(1),
                userData: "",
                isPersistent: false,
                cookiePath: FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            Response.Cookies.Add(cookie);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Resource(string culture)
        {
            CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo newCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            return this.View();
        }
    }
}