using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.DI
{
    public interface IOrderRespository
    {
        bool AddOrder(object orderDetails);
        bool ModifyOrder(object orderDetails);
        object GetOrderDetails(string orderId);
    }
}
