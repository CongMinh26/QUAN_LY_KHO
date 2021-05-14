using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModel.User
{
    public class UpdateRequest
    {
        public String  id { get; set; }

        [Display(Name = "Họ Tên")]
        public string name { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public System.DateTime NGAYSINH { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }
    }
}
