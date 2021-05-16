using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class PagingRequestBase 
    {
        public string Keyword { get; set; }

        // thuộc tính của 1 trang
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
