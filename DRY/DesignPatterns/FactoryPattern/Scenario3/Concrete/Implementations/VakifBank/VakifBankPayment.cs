using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.VakifBank
{
    public class VakifBankPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            VakifBankPayInputModel inputModel = (VakifBankPayInputModel)payInputModel;

            // pay...

            return new VakifBankPayOutputModel
            {
                BankName = typeof(VakifBankPayment).Name,
                TransactionId = nameof(VakifBankPayment) + inputModel.OrderNumber
            };
        }
    }
}
