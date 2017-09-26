using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Filter.Filter
{
    public class ResultAttribute : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("结果后");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("结果前");
        }
    }
}