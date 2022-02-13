using DRY.DesignPatterns.FactoryPattern.Scenario2.Abstract;
using DRY.DesignPatterns.FactoryPattern.Scenario2.Enum;

namespace DRY.DesignPatterns.FactoryPattern.Scenario2.Concrete
{
    public class DrivingSchoolFactory
    {
        public static DriverLicence CreateLicence(DriverLicenceType type)
        {
            DriverLicence driverLicence = null;

            switch (type)
            {
                case DriverLicenceType.A:
                    driverLicence = new DriverLicenceA();
                    break;
                case DriverLicenceType.B:
                    driverLicence = new DriverLicenceB();
                    break;
                case DriverLicenceType.E:
                    driverLicence = new DriverLicenceE();
                    break;
            }

            return driverLicence;
        }
    }
}
