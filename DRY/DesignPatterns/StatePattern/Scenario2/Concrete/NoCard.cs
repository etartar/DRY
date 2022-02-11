using DRY.DesignPatterns.StatePattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Concrete
{
    public class NoCard : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Lütfen önce kartınızı takınız.");
        }

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Lütfen pin giriniz.");
            context.State = new HasCard();
        }

        public override void InsertPin(int pin, ATMMachine context)
        {
            Console.WriteLine("Lütfen önce kartınızı takınız.");
        }

        public override void RequestCash(int cashToWithDraw, ATMMachine context)
        {
            Console.WriteLine("Lütfen önce kartınızı takınız.");
        }
    }
}
