using System;
using System.Diagnostics;

namespace DRY.Disposable
{
    public class PerformanceOperation : IDisposable
    {
        private readonly Stopwatch _stopwatch;
        private readonly string _title;

        public PerformanceOperation()
        {
            _stopwatch = Stopwatch.StartNew();
            _title = "Operation Take";
        }

        public PerformanceOperation(string title)
        {
            _stopwatch = Stopwatch.StartNew();
            _title = title;
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            Console.WriteLine($"{_title} {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
