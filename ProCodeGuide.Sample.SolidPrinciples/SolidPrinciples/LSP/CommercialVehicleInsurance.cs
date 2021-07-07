using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.LSP
{
    public class CommercialVehicleInsurance : MotorInsurance
    {
        public override bool IssuePolicy()
        {
            //Logic to Issue & Generate Policy

            return true;
        }

        public override bool GetPassengerCover()
        {
            return true;
        }
    }
}
