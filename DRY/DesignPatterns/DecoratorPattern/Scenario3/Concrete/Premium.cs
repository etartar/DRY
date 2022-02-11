using DRY.DesignPatterns.DecoratorPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete
{
    public class Premium : ICar
    {
        private readonly ICar _car;

        public Premium(ICar car)
        {
            _car = car;
        }

        public string GetFeatures()
        {
            return $"{_car.GetFeatures()}\n *Leather Seating Surfaces,\n *Ventilated Seats,";
        }

        public decimal GetPrice()
        {
            return _car.GetPrice() + 4500m;
        }
    }
}
