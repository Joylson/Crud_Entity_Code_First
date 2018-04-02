using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Entity.Filters
{
    public class ManagerFilters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            Controller controller = filterContext.Controller as Controller;
            if (ctx.Session["Login"] == null )
                controller.HttpContext.Response.Redirect("./Login");
            base.OnActionExecuting(filterContext);
        }
    }
}