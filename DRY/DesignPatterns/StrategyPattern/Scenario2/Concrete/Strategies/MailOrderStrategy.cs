using DRY.DesignPatterns.StrategyPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete.Strategies
{
    public class MailOrderStrategy : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Mail order yöntemi ile ödeme yapıldı.");
        }
    }
}
