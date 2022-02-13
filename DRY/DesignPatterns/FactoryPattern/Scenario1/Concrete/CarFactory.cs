using DRY.DesignPatterns.FactoryPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.FactoryPattern.Scenario1.Concrete
{
    public class CarFactory
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        public static ICar CreateCar(string mark, string color, double price, int modelYear, bool backupCamera)
        {
            ICar car;

            if (mark.Equals("BMW"))
                car = new BMW(color, price, modelYear, backupCamera);
            else if (mark.Equals("Audi"))
                car = new Audi(color, price, modelYear, backupCamera);
            else
                throw new NotSupportedException($"{mark} markasının üretimi desteklenmemektedir.");

            return car;
        }
    }
}
