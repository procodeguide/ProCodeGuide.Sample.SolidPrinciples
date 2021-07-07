using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP.ecommerce
{
    public class OrderWithOnlinePayment : Order, IPaymentOnline
    {
        public bool MakePaymentByBank(double amount)
        {
            //Payment Workflow as per Online internet banking

            return true;
        }

        public bool MakePaymentByCC(double amount)
        {
            //Payment Workflow as per Credit Card Payment

            return true;
        }
    }
}
