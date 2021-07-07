using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP.ecommerce
{
    public abstract class Order
    {
        public string OrderId { get; set; }

        public string CreateOrder(object orderObject)
        {
            return OrderId;
        }

        public object GetOrderDetails(string orderId)
        {
            object OrderDetails = new object();

            return OrderDetails;
        }
    }
}
