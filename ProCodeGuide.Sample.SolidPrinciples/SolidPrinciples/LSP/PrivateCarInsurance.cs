using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.LSP
{
    public class PrivateCarInsurance : MotorInsurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }
    }
}
