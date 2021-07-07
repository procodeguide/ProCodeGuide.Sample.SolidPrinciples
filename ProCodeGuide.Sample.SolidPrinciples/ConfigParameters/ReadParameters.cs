using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.ConfigParameters
{
    public abstract class ReadParameters
    {
        public abstract string GetDbConnString();

        public string ParseServerDetails(string DbConn)
        {
            return DbConn + " - Parsed";
        }
    }
}
