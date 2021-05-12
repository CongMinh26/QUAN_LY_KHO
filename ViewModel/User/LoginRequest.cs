using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.User
{
    public class LoginRequest
    {
        public string TAIKHOAN { get; set; }
        public string MATKHAU { get; set; }
        public bool remember { get; set; }

    }
}
