using BEL;
using BLL.Mapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
        public static void Add(ProductAddModel model)
        {
            var data = AutoMapper.Mapper.Map<ProductAddModel, Product>(model);
            ProductRepo.Add(data);

        }
        public static List<ProductModel> GetAllProduct()
        {
            var cDetails = ProductRepo.GetProducts();
            //return AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(cDetails);
            List<ProductModel> data = new List<ProductModel>();
            foreach (var item in cDetails)
            {
                ProductModel p = new ProductModel()
                {
                    Id=item.Id,
                    Name=item.Name,
                    CategoryId=item.CategoryId,
                    Price = item.Price,
                    Qty = item.Qty,
                    Description =item.Description,
                    Created_at=item.Created_at,
                    Updated_at=item.Updated_at,
                    Deleted_at=item.Deleted_at,
                    Created_by=item.Created_by,
                    Deleted_by=item.Deleted_by,
                    Updated_by=item.Updated_by
                };
                data.Add(p);
            }
            return data;
        }
        public static List<ProductDetailsModel> GetProductDetails()
        {
            var cDetails = ProductRepo.GetProducts();
            //return AutoMapper.Mapper.Map<List<Product>, List<ProductDetailsModel>>(cDetails);
            List<ProductDetailsModel> data = new List<ProductDetailsModel>();
            foreach (var item in cDetails)
            {
                ProductDetailsModel p = new ProductDetailsModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryId = item.CategoryId,
                    Price = item.Price,
                    Qty=item.Qty,
                    Description = item.Description,
                    Created_at = item.Created_at,
                    Updated_at = item.Updated_at,
                    Deleted_at = item.Deleted_at,
                    Created_by = item.Created_by,
                    Deleted_by = item.Deleted_by,
                    Updated_by = item.Updated_by,
                    CategoryName=item.Name
                };
                data.Add(p);
            }
            return data;
        }
        public static List<string> GetNames()
        {
            var data = ProductRepo.GetNames();
            //var data = AutoMapper.Mapper.Map<Category,CategoryDetailsModel>();
            return data;
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            return AutoMapper.Mapper.Map<Product, ProductModel>(data);
        }
    }
}
