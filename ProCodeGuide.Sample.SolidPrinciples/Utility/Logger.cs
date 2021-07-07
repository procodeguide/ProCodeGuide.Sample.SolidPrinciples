using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.Utility
{
    public class Logger : IUtility
    {
        public bool LogData(string logdata)
        {
            //Log data to File

            return true;
        }

        public string GetDbConnStringFromConfig()
        {
            throw new NotImplementedException();
        }

        public object GetTransaction(string tranID)
        {
            throw new NotImplementedException();
        }

        public bool SaveTransaction(object tranData)
        {
            throw new NotImplementedException();
        }
    }
}
