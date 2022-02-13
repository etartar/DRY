using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Railway
{
    public class TrainStation : ITransportationStation
    {
        public void DistanceToCityCenter()
        {
            Console.WriteLine("The distance from train station to the city center is 10 kilometers.");
        }
    }
}
