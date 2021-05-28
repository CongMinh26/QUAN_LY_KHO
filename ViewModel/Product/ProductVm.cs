using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Product
{
    public class ProductVm
    { 
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int amount { get; set; }
        public string photo { get; set; }
        public double priceIm { get; set; }
        public double priceEx { get; set; }
    }
}
