using DRY.Loop;
using DRY.ReplaceIFElseStatement;
using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopExample();
            ReplaceIfElseStatement();
            SmartEnumeration();

            Console.WriteLine("Hello World!");
        }

        #region LoopExample
        static void LoopExample()
        {
            LoopProgram.ForLoop();
            LoopProgram.ForeachLoop();
            LoopProgram.TupleWithSelectMethod();
            LoopProgram.ExtensionLoop();
        }
        #endregion

        #region [Replace If Else Statement]
        static void ReplaceIfElseStatement()
        {
            var replaceIfElseStatementBad = new ReplaceIFElseStatementBad();
            var replaceIfElseStatementGood = new ReplaceIFElseStatementGood();
            Console.WriteLine(replaceIfElseStatementBad.CalculateTotalAfterDiscount());
            Console.WriteLine(replaceIfElseStatementGood.CalculateTotalAfterDiscount());
        }
        #endregion

        #region Smart Enumeration
        static void SmartEnumeration()
        {
            //
        }
        #endregion
    }
}
