using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public System.DateTime Order_Date { get; set; }
        public System.TimeSpan Order_Time { get; set; }
        public int ProductPrice { get; set; }
    }
}
