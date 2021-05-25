using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public PagedResult()
        {

        }
        // trả về danh sách các item trong 1 trang
        public string status { set; get; }  
        public string message { set; get; }   
        public List<T> data { set; get; }   // danh sách bản ghi
    }
}
