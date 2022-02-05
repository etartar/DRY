using DRY.Loop;
using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopExample();

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
    }
}
