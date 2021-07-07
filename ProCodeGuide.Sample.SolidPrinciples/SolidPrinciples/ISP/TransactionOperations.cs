using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP
{
    public class TransactionOperations : ITransactionOperations
    {
        public object GetTransaction(string tranID)
        {
            Object objTran = new object();
            //Retrieve Transaction

            return objTran;
        }

        public bool SaveTransaction(object tranData)
        {
            //Save Transaction

            return true;
        }
    }
}
