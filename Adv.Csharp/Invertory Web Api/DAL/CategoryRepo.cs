using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static IMSEntities context;
        static CategoryRepo()
        {
            context =new IMSEntities();
        }
        public static void Add(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();
        }
        public static List<Category> GetAllCategories()
        {
            var data=context.Categories.ToList();
            return data;
        }
        public static Category GetCategory(int id)
        {
            var data = context.Categories.Where(e=>e.Id==id).FirstOrDefault();
            return data;
        }

        public static List<string> GetNames()
        {
            var names = context.Categories.Select(e => e.Name).ToList();
            return names;
        }
    }
}
