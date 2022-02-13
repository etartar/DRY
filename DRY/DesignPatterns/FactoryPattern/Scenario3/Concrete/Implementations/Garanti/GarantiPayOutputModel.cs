using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.Garanti
{
    public class GarantiPayOutputModel : IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; set; }
    }
}
