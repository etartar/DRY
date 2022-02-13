using DRY.DesignPatterns.FactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.FactoryPattern.Scenario2.Concrete
{
    public class DriverLicenceB : DriverLicence
    {
        public override void Drive()
        {
            Console.WriteLine("Bu ehliyet sınıfında otomobil kullanabilirsiniz.");
        }
    }
}
