using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP.ecommerce
{
    public interface IPaymentOnline
    {
        bool MakePaymentByCC(double amount);
        bool MakePaymentByBank(double amount);
    }
}
