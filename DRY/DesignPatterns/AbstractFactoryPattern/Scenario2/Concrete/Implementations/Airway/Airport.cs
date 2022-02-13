using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Airway
{
    public class Airport : ITransportationStation
    {
        public void DistanceToCityCenter()
        {
            Console.WriteLine("The distance from airport to the city center is 50 kilometers.");
        }
    }
}
