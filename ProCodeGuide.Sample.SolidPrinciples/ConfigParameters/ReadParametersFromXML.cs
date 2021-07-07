using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.ConfigParameters
{
    public class ReadParametersFromXML : ReadParameters
    {
        public override string GetDbConnString()
        {
            string dbConn = "Connection String From XML File";

            //Read XML file to get Connection String

            dbConn = ParseServerDetails(dbConn);

            return dbConn;
        }
    }
}
