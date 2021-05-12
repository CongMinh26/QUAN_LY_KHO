using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModel.User
{
    public class NhanVienVm
    {

        public int MANV { get; set; }

        [Display(Name = "Họ")]
        public string HO { get; set; }

        [Display(Name = "Tên")]
        public string TEN { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PHONE { get; set; }

        [Display(Name = "Tài khoản")]
        public string TAIKHOAN { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Ngày sinh")]
        public System.DateTime NGAYSINH { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DIACHI { get; set; }
        public IList<string> Roles { get; set; }


       
        
        
       

        
    }
}
