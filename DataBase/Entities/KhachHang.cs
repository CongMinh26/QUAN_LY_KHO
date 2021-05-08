using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{
    public class KhachHang
    {
 
        public string MAKH { get; set; }

        public string HO { get; set; }

        public string TEN { get; set; }
        public string DIACHI { get; set; }

        public string EMAIL { get; set; }
    
        public string SOTAIKHOAN { get; set; }

        public string SODIENTHOAI { get; set; }

        // 1-n
        public  List<PhieuXuat> PhieuXuats { get; set; }
    }
}
