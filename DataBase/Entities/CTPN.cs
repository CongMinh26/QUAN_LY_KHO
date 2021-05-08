using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

   public class CTPN
    {
       
        public string MAPN { get; set; }
      
        public string MAVT { get; set; }
        
        public int SOLUONG { get; set; }
   
        public double DONGIA { get; set; }

        public  PhieuNhap PhieuNhap { get; set; }
        public  VatTu VatTu { get; set; }
    }
}
