using DRY.ComputingBigCsv;
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
    }
}
