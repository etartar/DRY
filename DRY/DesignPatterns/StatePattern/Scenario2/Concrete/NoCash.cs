using DRY.DesignPatterns.StatePattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Concrete
{
    public class NoCash : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Para sizde şöhret sizde :)");
        }

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Para sizde şöhret sizde :)");
        }

        public override void InsertPin(int pin, ATMMachine context)
        {
            Console.WriteLine("Para sizde şöhret sizde :)");
        }

        public override void RequestCash(int cashToWithDraw, ATMMachine context)
        {
            Console.WriteLine("Para sizde şöhret sizde :)");
        }
    }
}
