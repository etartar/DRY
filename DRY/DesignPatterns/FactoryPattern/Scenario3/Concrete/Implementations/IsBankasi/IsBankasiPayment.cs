using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.IsBankasi
{
    public class IsBankasiPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            IsBankasiPayInputModel inputModel = (IsBankasiPayInputModel)payInputModel;

            // pay...

            return new IsBankasiPayOutputModel
            {
                BankName = typeof(IsBankasiPayment).Name,
                TransactionId = nameof(IsBankasiPayment) + inputModel.OrderNumber
            };
        }
    }
}
