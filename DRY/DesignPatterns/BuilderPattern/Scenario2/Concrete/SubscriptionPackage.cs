using DRY.DesignPatterns.BuilderPattern.Scenario2.Enums;

namespace DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete
{
    public class SubscriptionPackage
    {
        private SubscriptionPackage()
        {
        }

        public static SubscriptionPackage Create() => new SubscriptionPackage();

        public DurationType DurationType { get; private set; }
        public PackageType PackageType { get; private set; }
        public int Contacts { get; private set; }
        public int Admins { get; private set; }
        public int EmailSenderNames { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }
        public decimal PaymentTransactionRate { get; private set; }
        public decimal PaymentTransactionPrice { get; private set; }
        public bool IsDigitalMembership { get; private set; }
        public bool IsMultipleBankAccount { get; private set; }
        public bool IsAPIAccess { get; private set; }
        public string Storage { get; private set; }
        public string APILimits { get; private set; }

        public string PaymentTransactionFees
        {
            get
            {
                return $"{PaymentTransactionRate}% + ${PaymentTransactionPrice}";
            }
        }

        public void SetPackageType(PackageType value) => PackageType = value;
        public void SetDurationType(DurationType value) => DurationType = value;
        public void SetContacts(int value) => Contacts = value;
        public void SetAdmins(int value) => Admins = value;
        public void SetEmailSenderNames(int value) => EmailSenderNames = value;
        public void SetUnitPrice(decimal value) => UnitPrice = value;
        public void SetTotalPrice(decimal value) => TotalPrice = value;
        public void SetPaymentTransactionRate(decimal value) => PaymentTransactionRate = value;
        public void SetPaymentTransactionPrice(decimal value) => PaymentTransactionPrice = value;
        public void SetIsDigitalMembership(bool value) => IsDigitalMembership = value;
        public void SetIsMultipleBankAccount(bool value) => IsMultipleBankAccount = value;
        public void SetIsAPIAccess(bool value) => IsAPIAccess = value;
        public void SetStorage(string value) => Storage = value;
        public void SetAPILimits(string value) => APILimits = value;
    }
}
