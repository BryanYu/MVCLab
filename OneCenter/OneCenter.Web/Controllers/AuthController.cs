using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneCenter.BLL.Admin;
using OneCenter.Models.ViewModels.Auth;
using System.Web.Security;

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

        [NonAction]
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
    }
}