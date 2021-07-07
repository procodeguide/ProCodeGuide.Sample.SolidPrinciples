using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.Order
{
    public class OrderService
    {
        public string CreateOrder(string OrderDetails) 
        {
            string OrderId = "";
            //Code to Create Order
            return OrderId; 
        }
        
        public bool MakePayment(string OrderId) 
        {
            //Code to Make Payment
            return true; 
        }
        
        public bool GenerateInvoice(string OrderId) 
        {
            //Code to Generate Invoice
            return true; 
        }
        
        public bool EmailInvoice(string OrderId) 
        {
            //Code to Email Invoice
            return true; 
        }
    }
}
