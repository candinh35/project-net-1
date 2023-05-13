using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MyMvcProject.Areas.Admin.Controllers
{
    public class BaseController : Controller , IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(HttpContext.Session.GetString("AdminLogin") == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { Controller = "Login", Action = "Login" })
                );
            }
            else
            {
                base.OnActionExecuting(context);
            }
        }
    }
}
