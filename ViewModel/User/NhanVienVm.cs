using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModel.User
{
    public class NhanVienVm
    {

        public int id { get; set; }

        [Display(Name = "Tên")]
        public string name { get; set; }

        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Ngày sinh")]
        public string birthday { get; set; }

        [Display(Name = "Địa chỉ")]
        public string address { get; set; }
        public IList<string> Roles { get; set; }


    }
}
