﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace testMVC.Filters
{
    public class MyCustomAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
