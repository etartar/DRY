using DRY.DesignPatterns.StrategyPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario1.Concrete
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
