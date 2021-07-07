using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP.ecommerce
{
    public class OrderWithCashPayment : Order, IPaymentOffline
    {
        public bool MakePaymentByCash(double amount)
        {
            //Make enteries that payment needs to be collected in cash on delivery

            return true;
        }
    }
}
