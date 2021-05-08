using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{

    public class PhieuNhap
    {

        public string MAPN { get; set; }
        public System.DateTime NGAY { get; set; }
        public int MANV { get; set; }
        public string MANCC { get; set; }

        public  List<CTPN> CTPNs { get; set; }
        public  NhaCungCap NhaCungCap { get; set; }
        public  NhanVien NhanVien { get; set; }
    }
}
