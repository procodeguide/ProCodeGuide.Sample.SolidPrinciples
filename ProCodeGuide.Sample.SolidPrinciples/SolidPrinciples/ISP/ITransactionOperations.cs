using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP
{
    public interface ITransactionOperations
    {
        bool SaveTransaction(object tranData);
        object GetTransaction(string tranID);
    }
}
