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
    public class CategoryService
    {
        public static void Add(CategoryModel model)
        {
            var data = AutoMapper.Mapper.Map<CategoryModel,Category>(model);
            CategoryRepo.Add(data);

        }
        public static List<CategoryModel> GetAllCategories()
        {
            var cDetails = CategoryRepo.GetAllCategories();
            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(cDetails);
            return data;
        }
        public static List<CategoryDetailsModel> GetCategoryDetails()
        {
            var cDetails = CategoryRepo.GetAllCategories();
            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetailsModel>>(cDetails);
            return data;
        }
        public static List<string> GetNames()
        {
            var data=CategoryRepo.GetNames();
            //var data = AutoMapper.Mapper.Map<Category,CategoryDetailsModel>();
            return data;
        }
        public static CategoryModel GetCategory(int id)
        {
            var data = CategoryRepo.GetCategory(id);
            return AutoMapper.Mapper.Map<Category, CategoryModel>(data);
        }

    }
}
