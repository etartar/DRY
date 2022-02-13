using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.IsBankasi
{
    public class IsBankasiPayOutputModel : IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; set; }
    }
}
