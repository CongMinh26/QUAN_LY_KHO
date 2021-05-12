using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class PagingRequestBase 
    {
        // thuộc tính của 1 trang
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
