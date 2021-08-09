using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailService
    {
        public static List<OrderDetailModel> GetOrdersDetail()
        {
            var cDetails = OrderDetailRepo.GetOrdersDetail();
            return AutoMapper.Mapper.Map<List<OrderDetail>, List<OrderDetailModel>>(cDetails);
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

        public static OrderDetailModel GetOrderDetail(int id)
        {
            var data = OrderDetailRepo.GetOrderDetail(id);
            return AutoMapper.Mapper.Map<OrderDetail, OrderDetailModel>(data);
        }
        public static List<OrderAllDetailModel> GetAllOrderDetail(int id)
        {
            var data = OrderDetailRepo.GetAllOrderDetail(id);
            return AutoMapper.Mapper.Map<List<OrderDetail>, List<OrderAllDetailModel>>(data);
        }
    }
}
