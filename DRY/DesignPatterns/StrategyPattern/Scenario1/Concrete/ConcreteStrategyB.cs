using DRY.DesignPatterns.StrategyPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario1.Concrete
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
