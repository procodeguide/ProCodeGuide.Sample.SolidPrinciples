using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.LSP
{
    public abstract class MotorInsurance
    {
        public abstract bool IssuePolicy();

        public virtual bool GetPassengerCover()
        {
            return false;
        }
    }
}
