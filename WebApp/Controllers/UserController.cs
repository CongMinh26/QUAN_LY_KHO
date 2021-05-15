using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.User;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;

        private readonly IConfiguration _configuration;

        public UserController(IUserApiClient userApiClient,
            IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("User");
            var data = await _userApiClient.GetAllUser();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            var result = await _userApiClient.Register(request);
            if(result.data == null)
            {
                ModelState.AddModelError("", result.message);
                return View();
            }

            return RedirectToAction("Index","Login");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userApiClient.Detail(id);
            return View(new DeleteRequest
            {
                id = result.data.id,
                name = result.data.name,
                email = result.data.email,
            }) ;
        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRequest request)
        {
            var result = await _userApiClient.Delete(request.id);
            if (result.data == null)
            {
                return RedirectToAction("Index", "User");
                
            }
            ModelState.AddModelError("", result.message);
            return View();

        }

          [HttpGet]
          public async Task<IActionResult> Edit(int id) 
           {
                var result = await _userApiClient.Detail(id);
            var UpdateRequest = new NhanVienVm()
            {
                id = result.data.id,
                name = result.data.name,
                phone = result.data.phone,
                email = result.data.email,
                birthday = result.data.birthday
            };
                return View(UpdateRequest);

           }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,NhanVienVm request)
        {
            var result = await _userApiClient.Update(id,request);
          if(result.status.Equals("1") == true)
            {
              
                return RedirectToAction("Index");
               
            }
            return View();
            ModelState.AddModelError("", result.message);
        }



        [HttpGet]        
        public async Task<IActionResult> Details(int id)
        {
            var result = await _userApiClient.Detail(id);
            if (result.data == null)
            {
                ModelState.AddModelError("", result.message);
                return View();
            }

            return View(result.data);
        }


    }
}
