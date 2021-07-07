using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.ISP
{
    public class Logger : ILogging
    {
        public bool LogData(string logdata)
        {
            //Log data to File

            return true;
        }
    }
}
