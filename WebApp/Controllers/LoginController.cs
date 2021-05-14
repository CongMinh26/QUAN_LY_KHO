using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.User;
using WebApp.Service;

namespace WebApp.Controllers
{
    

    public class LoginController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;

        public LoginController(IUserApiClient userApiClient,
            IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest request)
        {
            var result = await _userApiClient.Login(request);
            if (result.data == null)
            {
                ModelState.AddModelError("", result.message); // xuất ra lỗi
                return View();
            }
            HttpContext.Session.SetString("User", result.data.name);

            return RedirectToAction("Index", "Home");
        }
    }
}
