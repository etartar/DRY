using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Airway
{
    public class AirwayFactory : ITransportationFactory
    {
        public ITransportationStation CreateStation()
        {
            return new Airport();
        }

        public ITransportationVehicle CreateVehicle()
        {
            return new Plane();
        }
    }
}
