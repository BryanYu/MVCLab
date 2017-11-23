using OneCenter.BLL.Admin;
using OneCenter.Models.ViewModels.Admin;
using OneCenter.Web.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OneCenter.Models.ViewModels;

namespace OneCenter.Web.Controllers
{
    /// <summary>
    /// 管理員Controller
    /// </summary>
    [Authorize]
    public class AdminController : Controller
    {
        /// <summary>
        /// AdminService
        /// </summary>
        private AdminService _service;

        /// <summary>
        /// AdminController Constructor
        /// </summary>
        public AdminController()
        {
            this._service = new AdminService();
        }

        /// <summary>
        /// 取得所有管理員列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var result = this._service.GetAdmins();
            return View(result);
        }

        /// <summary>
        /// 取得建立管理員檢視
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 建立管理員
        /// </summary>
        /// <param name="model">model</param>
        /// <returns><see cref="ActionResult"/></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [LogActionFilter]
        public ActionResult Create(AdminViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                this._service.AddAdmin(model);

                //新增完回首頁
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 取得編輯管理員檢視
        /// </summary>
        /// <param name="id">id</param>
        /// <returns><see cref="ActionResult"/></returns>
        public ActionResult Edit(int id)
        {
            var result = this._service.GetAdmins().FirstOrDefault(item => item.Id == id);
            return View(result);
        }

        /// <summary>
        /// 編輯管理員
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(AdminViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                this._service.UpdateAdmin(model);
                // 編輯完回首頁
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

        /// <summary>
        /// 取得刪除管理員檢視
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id, string temp)
        {
            var result = this._service.GetAdmins().FirstOrDefault(item => item.Id == id);
            return View(result);
        }

        /// <summary>
        /// 刪除管理者
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                this._service.DeleteAdmin(id);
                // 刪除完回首頁
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

        [HttpGet]
        public ActionResult HtmlHeplerSample()
        {
            var viewModel = new TempData { Id = 1, Name = "Bryan", IsActive = true, Password = "1234" };
            IEnumerable<SelectListItem> list =
                new List<SelectListItem>()
                    {
                        new SelectListItem { Text = "序號1", Value = "1" },
                        new SelectListItem { Text = "序號2", Value = "2",Selected = true},
                        new SelectListItem { Text = "序號3", Value = "3" }
                    };

            viewModel.DrowSelectList = list;
            return this.View(viewModel);
        }
    }
}