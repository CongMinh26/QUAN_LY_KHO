using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.Common;

namespace ViewModel.User
{
    public class GetNhanVienPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
