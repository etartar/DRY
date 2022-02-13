using DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Concrete
{
    public class BMWCar : ICar
    {
        private string _color;
        private double _price;
        private int _modelYear;
        private bool _backupCamera;

        public BMWCar(string color, double price, int modelYear, bool backupCamera)
        {
            _color = color;
            _price = price;
            _modelYear = modelYear;
            _backupCamera = backupCamera;
        }

        public string Color { get => _color; }
        public double Price { get => _price; }
        public int ModelYear { get => _modelYear; }
        public bool BackupCamera { get => _backupCamera; }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Araba Markası : BMW");
            Console.WriteLine($"Araba Fiyatı : {Price}");
            Console.WriteLine($"Araba Model Yılı : {ModelYear}");

            if (BackupCamera)
                Console.WriteLine("Arka Kamera Özelliği : Var");
            else
                Console.WriteLine("Arka Kamera Özelliği : Yok");
        }
    }
}
