using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Invertory_Web_Api.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            var data = ProductService.GetNames();
            return data;
        }
        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductAddModel model)
        {
            ProductService.Add(model);
        }
        [Route("api/Product/{id}/GetProduct")]
        [HttpGet]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
        [Route("api/Product/All/GetProducts")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProduct();
        }
        [Route("api/Product/GetProductDetails")]
        [HttpGet]
        public List<ProductDetailsModel> GetProductDetails()
        {
            return ProductService.GetProductDetails();
        }

    }
}
