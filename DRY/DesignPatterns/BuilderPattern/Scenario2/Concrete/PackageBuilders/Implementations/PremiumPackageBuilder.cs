using DRY.DesignPatterns.BuilderPattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete.PackageBuilders.Implementations
{
    public class PremiumPackageBuilder : BasePackageBuilder, IPackageBuilder
    {
        public override void SetUnitPrice(decimal value)
        {
            base.SetUnitPrice(value);

            if (Package.Contacts > 0 && Package.UnitPrice > 0)
            {
                var x = Package.Contacts / 1000;
                var y = Package.UnitPrice * x;
                var z = y - 1;
                Package.SetUnitPrice(decimal.Round(z, 2));
            }
        }
    }
}
