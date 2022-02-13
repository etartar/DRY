namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract
{
    public interface IAbstractFactory
    {
        ICar CreateCar(string color, double price, int modelYear, bool backupCamera);
        IMotorCycle CreateMotorCycle(string type, string color, double price, int modelYear);
    }
}
