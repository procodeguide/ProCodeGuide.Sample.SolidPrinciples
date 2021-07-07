using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.Utility
{
    public class ConfigParameters : IUtility
    {
        public string GetDbConnStringFromConfig()
        {
            string dbConn = string.Empty;

            //Read Connection String From Config

            return dbConn;
        }

        public object GetTransaction(string tranID)
        {
            throw new NotImplementedException();
        }

        public bool LogData(string logdata)
        {
            throw new NotImplementedException();
        }

        public bool SaveTransaction(object tranData)
        {
            throw new NotImplementedException();
        }
    }
}
