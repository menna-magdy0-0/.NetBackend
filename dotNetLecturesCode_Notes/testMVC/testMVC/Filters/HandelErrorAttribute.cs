using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace testMVC.Filters
{
    public class HandelErrorAttribute :Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Error";

            //catch
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "Error";
            context.Result = viewResult;
        }
    }
}
