using ProCodeGuide.Sample.SolidPrinciples.ConfigParameters;
using ProCodeGuide.Sample.SolidPrinciples.OrderDI;
using ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.LSP;
using System;

namespace ProCodeGuide.Sample.Solid.ConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            /*ReadParameters readParameters = new ReadParametersFromXML();
            Console.WriteLine(readParameters.GetDbConnString());

            readParameters = new ReadParametersFromJSON();
            Console.WriteLine(readParameters.GetDbConnString());*/
            
            MotorInsurance motorInsurance = new PrivateCarInsurance();
            Console.WriteLine("PrivateCarInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

            motorInsurance = new TwoWheelerInsurance();
            Console.WriteLine("TwoWheelerInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

            motorInsurance = new CommercialVehicleInsurance();
            Console.WriteLine("CommercialVehicleInsurance => PassengerCover => " + motorInsurance.GetPassengerCover());

            Console.ReadKey();
        }
    }
}
