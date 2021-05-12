using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.User
{
    public class RegisterRequest
    {
        public string HO { get; set; }

        public string TEN { get; set; }

        public System.DateTime NGAYSINH { get; set; }

        public string EMAIL { get; set; }

        public string PHONE { get; set; }

        public string TAIKHOAN { get; set; }

        public string MATKHAU { get; set; }

        public string ConfirmMatKhau { get; set; }
    }
}
