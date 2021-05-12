using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{

    public class NhanVien : IdentityUser<Guid>
    {

        public int MANV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public string DIACHI { get; set; }
        public string PHONE { get; set; }
        public System.DateTime NGAYSINH { get; set; }
        public double LUONG { get; set; }

        public string EMAIL { get; set; }
        public string TAIKHOAN { get; set; }

        public string MATKHAU { get; set; }

        // 1 nv có nhiều phiếu nhập 
        public  List<PhieuXuat> PhieuXuats { get; set; }
        public  List<PhieuNhap> PhieuNhaps { get; set; }

    }
}
