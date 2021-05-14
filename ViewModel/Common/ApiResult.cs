using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class ApiResult<T>
    {
        public string status { get; set; }
        public T data { get; set; }
        public string message { get; set; }

       
    }
}
