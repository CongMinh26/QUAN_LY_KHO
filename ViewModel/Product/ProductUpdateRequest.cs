using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.Product
{
    public class ProductUpdateRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int amount { get; set; }
        public string photo { get; set; }
        public double price { get; set; }
        public IFormFile thumbnailImages { get; set; }
    }
}
