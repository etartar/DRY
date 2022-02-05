using DRY.Disposable;
using DRY.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DRY.Loop
{
    public class LoopProgram
    {
        private static readonly List<int> _myValues = new List<int>() { 23, 56, 97, 45 };

        public static void ForLoop()
        {
            using (var po = new PerformanceOperation("FoorLoop Operation Take"))
            {
                for (int i = 0; i < _myValues.Count; i++)
                {
                    Console.WriteLine($"Index {i} Value {_myValues[i]}");
                }
            }
        }

        public static void ForeachLoop()
        {
            using (var po = new PerformanceOperation("ForeachLoop Operation Take"))
            {
                int counter = 0;

                foreach (int item in _myValues)
                {
                    Console.WriteLine($"Index {counter} Value {item}");
                    counter++;
                }
            }
        }

        public static void TupleWithSelectMethod()
        {
            using (var po = new PerformanceOperation("TupleWithSelectMethod Operation Take"))
            {
                foreach (var item in _myValues.Select((value, i) => (value, i)))
                {
                    Console.WriteLine($"Index {item.i} Value {item.value}");
                }
            }
        }

        public static void ExtensionLoop()
        {
            using (var po = new PerformanceOperation("Extension Loop"))
            {
                foreach (var item in _myValues.LoopIndex())
                {
                    Console.WriteLine($"Index {item.index} Value {item.item}");
                }
            }
        }
    }
}