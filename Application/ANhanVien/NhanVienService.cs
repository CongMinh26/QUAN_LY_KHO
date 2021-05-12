using DataBase.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.User;

namespace Application.ANhanVien
{
    public class NhanVienService : INhanVienService
    {
        // Hàm của Identity
        private readonly UserManager<NhanVien> _userManager;
        private readonly SignInManager<NhanVien> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;

        public NhanVienService(UserManager<NhanVien> userManager, SignInManager<NhanVien> signInManager,
            RoleManager<Role> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<ApiResult<bool>> Delete(DeleteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<NhanVienVm>> GetById(string MANV)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<PagedResult<NhanVienVm>>> GetNhanVienPaging(GetNhanVienPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Update(UpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
