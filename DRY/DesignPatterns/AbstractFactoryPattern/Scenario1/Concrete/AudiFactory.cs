using DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Concrete
{
    public class AudiFactory : IAbstractFactory
    {
        public ICar CreateCar(string color, double price, int modelYear, bool backupCamera)
        {
            return new AudiCar(color, price, modelYear, backupCamera);
        }

        public IMotorCycle CreateMotorCycle(string type, string color, double price, int modelYear)
        {
            return new AudiMotorCycle(type, color, price, modelYear);
        }
    }
}
