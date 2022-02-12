using DRY.DesignPatterns.StrategyPattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete
{
    public class PaymentOperation
    {
        private IPayment _payment;

        public PaymentOperation()
        {
        }

        public void SetPayment(IPayment payment) => _payment = payment;

        public void MakePayment()
        {
            _payment.MakePayment();
        }
    }
}
