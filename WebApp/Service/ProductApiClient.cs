using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.Product;
namespace WebApp.Service
{
    public class ProductApiClient : Base, IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
              : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<PagedResult<ProductVm>> GetAll()
        {
            var data = await GetAsync<PagedResult<ProductVm>>("api/products");
            return data;
        }

        public async Task<ApiResult<ProductVm>> Add(ProductVm product)
        {
            var data = await AddAsync<ApiResult<ProductVm>>("api/products", product);
            return data;
        }

        public async Task<ApiResult<ProductVm>> Delete(int id)
        {
            var data = await Delete<ApiResult<ProductVm>>($"api/products/{id}");
            return data;
        }

        public async Task<ApiResult<ProductVm>> Update(int id, ProductVm product)
        {
            var data = await UpdateAsync<ApiResult<ProductVm>>($"api/products/{id}",product);
            return data;
        }

        public async Task<ApiResult<ProductVm>> GetById(int id)
        {
            var data = await GetAsync<ApiResult<ProductVm>>($"api/products/{id}");
            return data;
        }
    }
}
