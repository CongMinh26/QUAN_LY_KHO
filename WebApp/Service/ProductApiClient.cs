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
        protected ProductApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
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

        public Task<ApiResult<ProductVm>> Delete(int id)
        {
            throw new NotImplementedException();
        }

     
        public Task<ApiResult<ProductVm>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<ProductVm>> Update(int id, ProductVm product)
        {
            throw new NotImplementedException();
        }
    }
}
