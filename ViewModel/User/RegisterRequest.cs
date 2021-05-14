using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.User
{
    public class RegisterRequest
    {
        public string name { get; set; }
        public string birthday { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
    }
}
