using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.Garanti;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.IsBankasi;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.VakifBank;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete
{
    public static class PaymentFactory
    {
        public static IPayment InitializePayment(string cardNumber)
        {
            /// Cards starting with number 1 Garanti
            /// Cards starting with number 2 İş Bankası
            /// Cards starting with number 3 VakıfBank

            IPayment payment = cardNumber switch
            {
                string s when s.StartsWith("1") => new GarantiPayment(),
                string s when s.StartsWith("2") => new IsBankasiPayment(),
                string s when s.StartsWith("3") => new VakifBankPayment(),
                _ => new GarantiPayment(),
            };

            return payment;
        }
    }
}
