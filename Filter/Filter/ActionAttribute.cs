using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Filter.Filter
{
    public class ActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting");
        }
    }
}