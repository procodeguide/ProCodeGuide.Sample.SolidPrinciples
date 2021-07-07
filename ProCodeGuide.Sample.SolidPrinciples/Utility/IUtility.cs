using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.Utility
{
    public interface IUtility
    {
        bool LogData(string logdata);
        string GetDbConnStringFromConfig();
        bool SaveTransaction(object tranData);
        object GetTransaction(string tranID);
    }
}
