using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thuctap01.Constanst;

namespace Thuctap01.Filters
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterConetxt)
        {
            Controller controller = filterConetxt.Controller as Controller;
            var session = filterConetxt.HttpContext.Session;
            string UserName = filterConetxt.HttpContext.Session.GetString(SessionKey.KeToanTruong.UserName);
            var sessionStatus = ((UserName != null && UserName != "") ? true : false);
            if (controller != null)
            {
                if (session == null || !sessionStatus)
                {
                    filterConetxt.Result =
                           new RedirectToRouteResult(
                               new RouteValueDictionary{
                                   { "controller", "KeToanTruong" },
                                   { "action", "Login" }}
                               );

                }
            }
            base.OnActionExecuting(filterConetxt);

        }
    }
}
