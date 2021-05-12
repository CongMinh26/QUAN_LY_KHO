using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModel.User
{
    public class UpdateRequest
    {
        public String  MANV { get; set; }

        [Display(Name = "Tên")]
        public string TEN { get; set; }

        [Display(Name = "Họ")]
        public string HO { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public System.DateTime NGAYSINH { get; set; }

        [Display(Name = "Hòm thư")]
        public string EMAIL { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PHONE { get; set; }
    }
}
