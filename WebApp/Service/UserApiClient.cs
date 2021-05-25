using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.User;

namespace WebApp.Service
{
    public class UserApiClient :Base, IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
              : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public  async Task<ApiResult<NhanVienVm>> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://lit-reaches-20158.herokuapp.com");

            var response = await client.DeleteAsync($"api/users/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<NhanVienVm>>(body);
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<NhanVienVm>>(body);
        }

        public async Task<ApiResult<NhanVienVm>> Detail(int id)
        {
            var data = await GetAsync<ApiResult<NhanVienVm>>($"api/users/{id}");

            return data;
        }

        public async Task<PagedResult<NhanVienVm>> GetAllUser()
        {
            var data = await GetAsync<PagedResult<NhanVienVm>>("api/users");
            return data;
        }

        public async Task<ApiResult<NhanVienVm>> Login(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://lit-reaches-20158.herokuapp.com");
            var response = await client.PostAsync("/api/login", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<NhanVienVm>>(body);
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<NhanVienVm>>(body);
        }

        public async Task<ApiResult<NhanVienVm>> Register(RegisterRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://lit-reaches-20158.herokuapp.com");

            var response = await client.PostAsync("/api/users", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<NhanVienVm>>(body);
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<NhanVienVm>>(body);

        }

        public async Task<ApiResult<NhanVienVm>> Update(int id, NhanVienVm nhanVien)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://lit-reaches-20158.herokuapp.com");
            var json = JsonConvert.SerializeObject(nhanVien);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/users/{id}", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<NhanVienVm>>(body);

            return JsonConvert.DeserializeObject<ApiErrorResult<NhanVienVm>>(body);
        }
    }
    
}
