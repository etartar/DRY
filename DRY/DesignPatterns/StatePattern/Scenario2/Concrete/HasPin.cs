using DRY.DesignPatterns.StatePattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Concrete
{
    public class HasPin : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Kart çıkarılmıştır.");
            context.State = new NoCard();
        }

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Aynı anda birden fazla kart takamazsınız.");
        }

        public override void InsertPin(int pin, ATMMachine context)
        {
            Console.WriteLine("Doğrulanmış bir pin zaten girilmiştir.");
        }

        public override void RequestCash(int cashToWithDraw, ATMMachine context)
        {
            if (cashToWithDraw > context.CashInMachine)
            {
                Console.WriteLine("Çekmek istenen tutar adil bedeli aşmaktadır.");
                Console.WriteLine("Kart çıkarılmıştır.");
                context.State = new NoCard();
            }
            else
            {
                Console.WriteLine($"{cashToWithDraw} tutarında para çekilmiştir.");
                context.CashInMachine -= cashToWithDraw; //ATM'de ki para güncelleniyor.
                Console.WriteLine("Kart çıkarılmıştır.");
                context.State = new NoCard();
                Console.WriteLine($"ATM'de kalan para : {context.CashInMachine}");

                if (context.CashInMachine <= 0)
                    context.State = new NoCash();
            }
        }
    }
}
