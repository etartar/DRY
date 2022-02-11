using DRY.DesignPatterns.DecoratorPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete
{
    public class Comfort : ICar
    {
        private readonly ICar _car;

        public Comfort(ICar car)
        {
            _car = car;
        }

        public string GetFeatures()
        {
            return $"{_car.GetFeatures()}\n *Front Assist,\n *Panoramic Sunroof,";
        }

        public decimal GetPrice()
        {
            return _car.GetPrice() + 3000m;
        }
    }
}
