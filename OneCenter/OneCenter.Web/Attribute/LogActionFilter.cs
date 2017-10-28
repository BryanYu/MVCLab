using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace OneCenter.Web.Attribute
{
    public class LogActionFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Action執行前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting");

            base.OnActionExecuting(filterContext);
        }

        /// <summary>
        /// Action執行後
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted");

            base.OnActionExecuted(filterContext);
        }

        /// <summary>
        /// 拋出Result前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("OnResultExecuting");

            base.OnResultExecuting(filterContext);
        }

        /// <summary>
        /// 拋出Result後
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("OnResultExecuted");

            base.OnResultExecuted(filterContext);
        }
    }
}