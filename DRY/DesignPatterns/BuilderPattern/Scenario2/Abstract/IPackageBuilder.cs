using DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete;
using DRY.DesignPatterns.BuilderPattern.Scenario2.Enums;

namespace DRY.DesignPatterns.BuilderPattern.Scenario2.Abstract
{
    public interface IPackageBuilder
    {
        void Reset();
        SubscriptionPackage Build();
        void SetIsAPIAccess(bool value);
        void SetAPILimits(string value);
        void SetIsDigitalMembership(bool value);
        void SetIsMultipleBankAccount(bool value);
        void SetPackageType(PackageType value);
        void SetDurationType(DurationType value);
        void SetUnitPrice(decimal value);
        void SetStorage(string value);
        void SetAdminCount(int value);
        void SetContractCount(int value);
        void SetPaymentTransactionRate(decimal value);
        void SetPaymentTransactionPrice(decimal value);
        void SetEmailSenderCount(int value);
    }
}
