using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RubiconAssignment.WebAPI.Exceptions;
using System.Net;

namespace RubiconAssignment.WebAPI.Filters
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            CustomResponseMessage response = null;

            if(context.Exception is NotFoundException)
            {
                response = new CustomResponseMessage()
                {
                    Status = (int)HttpStatusCode.NotFound,
                    Error = "Client-Side Error",
                    Message = context.Exception.Message,
                };
            }
            else
            {
                response = new CustomResponseMessage()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Error = "Server-Side Error",
                    Message = context.Exception.Message,
                };
            }

            context.Result = new JsonResult(response);
        }
    }
}
