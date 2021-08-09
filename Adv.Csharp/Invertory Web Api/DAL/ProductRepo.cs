using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static IMSEntities context;
        static ProductRepo()
        {
            context = new IMSEntities();
        }
        public static void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
        public static List<Product> GetProducts()
        {
            
            return context.Products.ToList();
        }
        public static Product GetProduct(int id)
        {
            var data = context.Products.Where(e => e.Id == id).FirstOrDefault();
            return data;
        }

        public static List<string> GetNames()
        {
            var names = context.Products.Select(e => e.Name).ToList();
            return names;
        }
    }
}
