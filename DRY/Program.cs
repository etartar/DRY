using DRY.ComputingBigCsv;
using DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete;
using DRY.Loop;
using DRY.ReplaceIFElseStatement;
using DRY.SmartEnumeration;
using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopExample();
            //ReplaceIfElseStatement();
            //SmartEnumeration();
            //CsvReader();
            VisitorDesignPatternScenario1();

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
            Console.WriteLine(SmartEnumerationProgram.GetDiscount(EnumSubscription.Premium));
            Console.WriteLine(Subscriptions.Premium.Discount);
        }
        #endregion

        #region CsvReader
        static void CsvReader()
        {
            CsvReaderProgram.CsvReadWithoutPLINQ();
            CsvReaderProgram.CsvReadWithPLINQ();
        }
        #endregion

        #region [Visitor Design Pattern]
        static void VisitorDesignPatternScenario1()
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Sallesman("John");
            school.PerformOperation(visitor2);
        }
        #endregion
    }
}
