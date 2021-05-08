using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

    public class VatTu
    {
        public string MAVT { get; set; }
        public string TENVT { get; set; }
        public string DVT { get; set; }
        public string HinhAnh { get; set; }
        public int SOLUONGTON { get; set; }
        public  List<CTPN> CTPNs { get; set; }
        public  List<CTPX> CTPXs { get; set; }
    }
}
