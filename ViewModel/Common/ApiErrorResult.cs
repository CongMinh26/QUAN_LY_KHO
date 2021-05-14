using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public ApiErrorResult()
        {
        }

        public ApiErrorResult(string Status ,string Message)
        {
            status = Status;
            message = Message;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            status = "Eror";
            ValidationErrors = validationErrors;
        }
    }
}
