using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.OrderDI
{
    public class Order
    {
        private OrderRepository _orderRepository = null;

        public Order()
        {
            _orderRepository = new OrderRepository();
        }

        public bool AddOrder(object orderDetails)
        {
            return _orderRepository.AddOrder(orderDetails);
        }

        public bool ModifyOrder(object orderDetails)
        {
            return _orderRepository.ModifyOrder(orderDetails);
        }

        public object GetOrderDetails(string orderId)
        {
            return _orderRepository.GetOrderDetails(orderId);
        }
    }
}
