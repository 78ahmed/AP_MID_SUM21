using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public class OrderRepo
        {
            static IMSEntities context;
            static OrderRepo()
            {
                context = new IMSEntities();
            }
            public static void Add(Order o)
            {
                context.Orders.Add(o);
                context.SaveChanges();
            }
            public static List<Order> GetAllOrders()
            {
                var data = context.Orders.ToList();
                return data;
            }
            public static Order GetOrder(int id)
            {
                var data = context.Orders.Where(e => e.Id == id).FirstOrDefault();
                return data;
            }


        }
}
