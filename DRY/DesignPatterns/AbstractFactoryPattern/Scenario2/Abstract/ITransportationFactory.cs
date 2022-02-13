namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Abstract
{
    public interface ITransportationFactory
    {
        ITransportationVehicle CreateVehicle();
        ITransportationStation CreateStation();
    }
}
