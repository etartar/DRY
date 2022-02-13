using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.VakifBank
{
    public class VakifBankPayOutputModel : IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; set; }
    }
}
