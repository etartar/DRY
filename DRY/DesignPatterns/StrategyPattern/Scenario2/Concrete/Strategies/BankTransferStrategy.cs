using DRY.DesignPatterns.StrategyPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete.Strategies
{
    public class BankTransferStrategy : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Havale yöntemi ile ödeme yapıldı.");
        }
    }
}
