using DRY.DesignPatterns.DecoratorPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete
{
    public class Car : ICar
    {
        private string _brand;
        private string _model;
        private decimal _price;

        public Car(string brand, string model, decimal price)
        {
            _brand = brand;
            _model = model;
            _price = price;
        }

        public string GetFeatures()
        {
            return $"Brand : {_brand}, Model : {_model}";
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}
