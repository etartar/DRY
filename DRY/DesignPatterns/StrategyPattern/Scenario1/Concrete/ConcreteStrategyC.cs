using DRY.DesignPatterns.StrategyPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.StrategyPattern.Scenario1.Concrete
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
