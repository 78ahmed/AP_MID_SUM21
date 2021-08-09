using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailRepo
    {
        static IMSEntities context;
        static OrderDetailRepo()
        {
            context = new IMSEntities();
        }
        public static List<OrderDetail> GetOrdersDetail()
        {
            var data = context.OrderDetails.ToList();
            return data;
        }
        public static OrderDetail GetOrderDetail(int id)
        {
            var data = context.OrderDetails.Where(e => e.OrderDetailsId == id).FirstOrDefault();
            return data;
        }
        public static List<OrderDetail> GetAllOrderDetail(int id)
        {
            var data = context.OrderDetails.Where(e => e.OrderId == id).ToList();
            return data;
        }

    }
}
