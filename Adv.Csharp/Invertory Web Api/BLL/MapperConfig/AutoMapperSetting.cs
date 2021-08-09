using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class AutoMapperSetting:Profile
    {
        public AutoMapperSetting()
        {
            CreateMap<CategoryModel,Category>();
            CreateMap<Category,CategoryDetailsModel>();
            CreateMap<Category,CategoryModel>();
            CreateMap<ProductModel, Product>();
            CreateMap<List<Product>,List<ProductModel>>();
            CreateMap<List<Product>,List<ProductDetailsModel>>();
            CreateMap<Product, ProductModel>();
            CreateMap<ProductAddModel, Product>();
            CreateMap<Order, OrderModel>();
            CreateMap<OrderDetail, OrderDetailModel>();
            CreateMap<OrderDetail, OrderAllDetailModel>();
        }
    }
}
