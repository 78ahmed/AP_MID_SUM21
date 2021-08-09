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
    public class OrderController : ApiController
    {
        /*[Route("api/Order/Add")]
        [HttpPost]
        public void Add(OrderModel model)
        {
            OrderService.Add(model);
        }*/
        [Route("api/Order/{id}/GetOrder")]
        [HttpGet]
        public OrderModel GetOrder(int id)
        {
            return OrderService.GetOrder(id);
        }
        [Route("api/Order/All/GetOrders")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {
            return OrderService.GetAllOrder();
        }
    }
}
