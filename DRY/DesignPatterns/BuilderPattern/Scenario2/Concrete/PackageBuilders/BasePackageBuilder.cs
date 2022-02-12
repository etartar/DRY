using DRY.DesignPatterns.BuilderPattern.Scenario2.Abstract;
using DRY.DesignPatterns.BuilderPattern.Scenario2.Constants;
using DRY.DesignPatterns.BuilderPattern.Scenario2.Enums;

namespace DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete.PackageBuilders
{
    public class BasePackageBuilder : IPackageBuilder
    {
        public SubscriptionPackage Package;

        public BasePackageBuilder() => Reset();

        public SubscriptionPackage Build()
        {
            CalculateTotalPrice();
            SubscriptionPackage tempPackage = Package;
            Reset();
            return tempPackage;
        }

        public void Reset() => Package = SubscriptionPackage.Create();

        public void CalculateTotalPrice()
        {
            decimal totalPrice = decimal.Zero;

            if (Package.UnitPrice > 0)
            {
                totalPrice = decimal.Round(Package.UnitPrice * IntVariables.TotalMonth, 2);
            }

            Package.SetTotalPrice(totalPrice);
        }

        #region [Set Methods]
        public void SetAdminCount(int value) => Package.SetAdmins(value);
        public void SetAPILimits(string value) => Package.SetAPILimits(value);
        public void SetContractCount(int value) => Package.SetContacts(value);
        public void SetDurationType(DurationType value) => Package.SetDurationType(value);
        public void SetEmailSenderCount(int value) => Package.SetEmailSenderNames(value);
        public void SetIsAPIAccess(bool value) => Package.SetIsAPIAccess(value);
        public void SetIsDigitalMembership(bool value) => Package.SetIsDigitalMembership(value);
        public void SetIsMultipleBankAccount(bool value) => Package.SetIsMultipleBankAccount(value);
        public void SetPackageType(PackageType value) => Package.SetPackageType(value);
        public void SetPaymentTransactionPrice(decimal value) => Package.SetPaymentTransactionPrice(value);
        public void SetPaymentTransactionRate(decimal value) => Package.SetPaymentTransactionRate(value);
        public void SetStorage(string value) => Package.SetStorage(value);
        public virtual void SetUnitPrice(decimal value) => Package.SetUnitPrice(value);
        #endregion
    }
}
