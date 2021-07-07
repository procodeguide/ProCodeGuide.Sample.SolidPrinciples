using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP
{
    public class ConfigParameters : IConfigOperations
    {
        public string GetDbConnStringFromConfig()
        {
            string dbConn = string.Empty;

            //Read Connection String From Config

            return dbConn;
        }
    }
}
