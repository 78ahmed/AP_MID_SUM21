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
    public class OrderDetailController : ApiController
    {
        [Route("api/OrderDetail/{id}/GetOrderDetail")]
        [HttpGet]
        public OrderDetailModel GetOrderDetail(int id)
        {
            return OrderDetailService.GetOrderDetail(id);
        }
        [Route("api/OrderDetail/All/GetOrdersDetail")]
        [HttpGet]
        public List<OrderDetailModel> GetOrdersDetail()
        {
            return OrderDetailService.GetOrdersDetail();
        }

        [Route("api/OrderDetail/{id}/GetAllOrderDetail")]
        [HttpGet]
        public List<OrderAllDetailModel> GetAllOrderDetail(int id)
        {
            return OrderDetailService.GetAllOrderDetail(id);
        }
    }
}
