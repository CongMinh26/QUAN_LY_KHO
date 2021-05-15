using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.Product;

namespace WebApp.Service
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetAll();
        Task<ApiResult<ProductVm>> Add(ProductVm product);
        Task<ApiResult<ProductVm>> Delete(int id);
        Task<ApiResult<ProductVm>> Update(int id, ProductVm product);
        Task<ApiResult<ProductVm>> GetById(int id);
    }
}
