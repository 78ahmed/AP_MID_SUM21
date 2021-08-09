using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        /*public static void Add(OrderAddModel model)
        {
            var data = AutoMapper.Mapper.Map<OrderAddModel, Order>(model);
            OrderRepo.Add(data);

        }*/
        public static List<OrderModel> GetAllOrder()
        {
            var cDetails = OrderRepo.GetAllOrders();
            return AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(cDetails);
            /*List<OrderModel> data = new List<OrderModel>();
            foreach (var item in cDetails)
            {
                OrderModel p = new OrderModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryId = item.CategoryId,
                    Price = item.Price,
                    Qty = item.Qty,
                    Description = item.Description,
                    Created_at = item.Created_at,
                    Updated_at = item.Updated_at,
                    Deleted_at = item.Deleted_at,
                    Created_by = item.Created_by,
                    Deleted_by = item.Deleted_by,
                    Updated_by = item.Updated_by
                };
                data.Add(p);
            }
            return data;*/
        }
     
        public static OrderModel GetOrder(int id)
        {
            var data = OrderRepo.GetOrder(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(data);
        }
    }
}
