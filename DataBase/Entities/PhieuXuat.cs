using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

    public class PhieuXuat
    {
        public string MAPX { get; set; }
        public System.DateTime NGAY { get; set; }
        public string MAKH { get; set; }
        public int MANV { get; set; }
        public  List<CTPX> CTPXs { get; set; }
        public  KhachHang KhachHang { get; set; }
        public  NhanVien NhanVien { get; set; }
    }
}
