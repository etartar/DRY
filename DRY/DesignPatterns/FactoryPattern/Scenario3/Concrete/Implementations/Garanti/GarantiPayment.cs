using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.Garanti
{
    public class GarantiPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            GarantiPayInputModel inputModel = (GarantiPayInputModel) payInputModel;

            // pay...

            return new GarantiPayOutputModel
            {
                BankName = typeof(GarantiPayment).Name,
                TransactionId = nameof(GarantiPayment) + inputModel.OrderNumber
            };
        }
    }
}
