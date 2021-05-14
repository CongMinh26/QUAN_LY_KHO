using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.User;

namespace WebApp.Service
{
    public interface IUserApiClient
    {
        Task<ApiResult<NhanVienVm>> Login(LoginRequest request);
        Task<ApiResult<NhanVienVm>> Register(RegisterRequest request);
        Task<ApiResult<NhanVienVm>> Delete(int id);
        Task<ApiResult<NhanVienVm>> Detail(int id);
        Task<ApiResult<NhanVienVm>> Update(int id, NhanVienVm nhanVien);
        Task<PagedResult<NhanVienVm>> GetAllUser();
    }
}
