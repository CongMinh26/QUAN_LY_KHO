using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.User
{
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool remember { get; set; }

    }
}
