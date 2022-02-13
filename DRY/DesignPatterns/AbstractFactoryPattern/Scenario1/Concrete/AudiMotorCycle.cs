using DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Concrete
{
    public class AudiMotorCycle : IMotorCycle
    {
        private string _type;
        private string _color;
        private double _price;
        private int _modelYear;

        public AudiMotorCycle(string type, string color, double price, int modelYear)
        {
            _type = type;
            _color = color;
            _price = price;
            _modelYear = modelYear;
        }

        public string Type => _type;

        public string Color => _color;

        public double Price => _price;

        public int ModelYear => _modelYear;

        public void ShowMotorCycleInfo()
        {
            Console.WriteLine($"Motor Markası : Audi");
            Console.WriteLine($"Motor Tipi : {Type}");
            Console.WriteLine($"Motor Rengi : {Color}");
            Console.WriteLine($"Motor Fiyatı : {Price}");
            Console.WriteLine($"Motor Model Yılı : {ModelYear}");
        }
    }
}
