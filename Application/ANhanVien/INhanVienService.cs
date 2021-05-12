using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.User;

namespace Application.ANhanVien
{
    public interface INhanVienService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<bool>> Update(UpdateRequest request);
        Task<ApiResult<bool>> Delete(DeleteRequest request);
        Task<ApiResult<NhanVienVm>> GetById(string MANV);
        Task<ApiResult<PagedResult<NhanVienVm>>> GetNhanVienPaging(GetNhanVienPagingRequest request);

    }
}
