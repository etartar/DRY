using DRY.DesignPatterns.StrategyPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete.Strategies
{
    public class CreditCardStrategy : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Kredi kartı ile ödeme yapıldı.");
        }
    }
}
