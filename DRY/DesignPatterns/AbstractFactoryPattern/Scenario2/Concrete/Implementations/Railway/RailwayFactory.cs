using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Railway
{
    public class RailwayFactory : ITransportationFactory
    {
        public ITransportationStation CreateStation()
        {
            return new TrainStation();
        }

        public ITransportationVehicle CreateVehicle()
        {
            return new Train();
        }
    }
}
