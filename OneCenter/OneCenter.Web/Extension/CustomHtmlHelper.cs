using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace OneCenter.Web.Extension
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString CreateActionLink(this HtmlHelper htmlHelper, string name, string actionName, string controllerName = null, object routeValue = null)
        {
            return htmlHelper.ActionLink(
               name,
               actionName: actionName,
               controllerName: controllerName,
               routeValues: routeValue,
               htmlAttributes: new { @class = "btn btn-primary" });
        }

        public static MvcHtmlString EditActionLink(this HtmlHelper htmlHelper, string name, string actionName, string controllerName = null, object routeValue = null)
        {
            return htmlHelper.ActionLink(
                name,
                actionName: actionName,
                controllerName: controllerName,
                routeValues: routeValue,
                htmlAttributes: new { @class = "btn btn-warning" });
        }

        public static MvcHtmlString DeleteActionLink(this HtmlHelper htmlHelper, string name, string actionName, string controllerName = null, object routeValue = null)
        {
            return htmlHelper.ActionLink(
                name,
                actionName: actionName,
                controllerName: controllerName,
                routeValues: routeValue,
                htmlAttributes: new { @class = "btn btn-danger" });
        }
    }
}