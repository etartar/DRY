using DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Concrete
{
    public class BMWFactory : IAbstractFactory
    {
        public ICar CreateCar(string color, double price, int modelYear, bool backupCamera)
        {
            return new BMWCar(color, price, modelYear, backupCamera);
        }

        public IMotorCycle CreateMotorCycle(string type, string color, double price, int modelYear)
        {
            return new BMWMotorCycle(type, color, price, modelYear);
        }
    }
}
