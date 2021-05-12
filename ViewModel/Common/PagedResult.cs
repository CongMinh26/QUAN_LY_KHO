using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        // trả về danh sách các item trong 1 trang
        public List<T> Items { set; get; }   // danh sách bản ghi
    }
}
