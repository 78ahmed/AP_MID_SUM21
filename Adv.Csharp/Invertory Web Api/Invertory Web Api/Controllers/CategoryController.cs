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
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            var data = CategoryService.GetNames();
            return data;
        }
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryModel model)
        {
            CategoryService.Add(model);
        }
        [Route("api/Category/{id}/GetCategory")]
        [HttpGet]
        public CategoryModel GetCategory(int id)
        {
            return CategoryService.GetCategory(id);
        }
        [Route("api/Category/All/GetCategories")]
        [HttpGet]
        public List<CategoryModel> GetAllCategories()
        {
            return CategoryService.GetAllCategories();
        }
        [Route("api/Category/GetCategoryDetails")]
        [HttpGet]
        public List<CategoryDetailsModel> GetCategoryDetails()
        {
            return CategoryService.GetCategoryDetails();
        }

    }
}
