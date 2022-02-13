using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Airway
{
    public class Plane : ITransportationVehicle
    {
        public void GetSpeed()
        {
            Console.WriteLine("The plane reaches 1300km/h");
        }
    }
}
