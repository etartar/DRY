using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Railway
{
    public class Train : ITransportationVehicle
    {
        public void GetSpeed()
        {
            Console.WriteLine("The train reaches 500km/h");
        }
    }
}
