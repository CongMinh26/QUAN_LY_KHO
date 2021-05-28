using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.Product;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;

        private readonly IConfiguration _configuration;

        public ProductController(IProductApiClient productApiClient,
            IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(int pageIndex = 1,int pageSize =2)
        {
           
            var datajson = await _productApiClient.GetAll();

            var item = datajson.data;
            var dataitem =item.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(x=> new ProductVm() { 
                name = x.name,
                photo =x.photo,
                unit = x.unit,
                priceIm = x.priceIm,                
                amount = x.amount
                }).ToList();

            var pagin = new PagedResult<ProductVm>()
            {
                data = dataitem,
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalRecords = datajson.data.Count,
            };

            return View(pagin);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductVm product)
        {
            var result = await _productApiClient.Add(product);
            if (result.data == null)
            {
                ModelState.AddModelError("", result.message);
                return View();
               
            }
            return RedirectToAction("Index","Product");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _productApiClient.GetById(id);
            var product = new ProductVm()
            {
                id = result.data.id,
                name = result.data.name,
                priceIm = result.data.priceIm,
                unit = result.data.unit,
                amount= result.data.amount,
                photo = result.data.photo,
            };
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, ProductVm product)
        {
            var result = await _productApiClient.Update(id,product);
            if (result.data == null)
            {
                return RedirectToAction("Index", "Product");
            }
            ModelState.AddModelError("", result.message);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productApiClient.GetById(id);
            return View(new ProductVm
            {
                id = result.data.id,
                name = result.data.name,
                priceIm = result.data.priceIm,
                unit = result.data.unit,
                amount = result.data.amount,
                photo = result.data.photo,
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ProductDelete product)
        {
            var result = await _productApiClient.Delete(product.id);
            if (result.data == null)
            {
                return RedirectToAction("Index", "Product");

            }
            ModelState.AddModelError("", result.message);
            return View();

        }
    }
}
