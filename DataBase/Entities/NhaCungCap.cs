using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{
    public class NhaCungCap
    {
        public string MANCC { get; set; }
        public string TEN { get; set; }
        public string SODIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string SOTAIKHOAN { get; set; }
         public  List<PhieuNhap> PhieuNhaps { get; set; }
    }
}
