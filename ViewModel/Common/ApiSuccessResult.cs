using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{

    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(string status,T data,string message)
        {
            this.status = status;
            this.data = data;
            this.message = message;
        }

        public ApiSuccessResult()
        {
            status = "";
        }
    }
}
