using DRY.DesignPatterns.FactoryPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.FactoryPattern.Scenario2.Concrete
{
    public class DriverLicenceE : DriverLicence
    {
        public override void Drive()
        {
            Console.WriteLine("Bu ehliyet sınıfında otobüs kullanabilirsiniz.");
        }
    }
}
