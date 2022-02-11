using DRY.DesignPatterns.DecoratorPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete
{
    public class Starter : ICar
    {
        private readonly ICar _car;

        public Starter(ICar car)
        {
            _car = car;
        }

        public string GetFeatures()
        {
            return $"{_car.GetFeatures()}\n *App Connect,\n *Led Headlights,";
        }

        public decimal GetPrice()
        {
            return _car.GetPrice() + 2000m;
        }
    }
}
