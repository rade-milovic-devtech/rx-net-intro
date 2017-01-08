using System;
using System.Diagnostics;

namespace UsingOperator
{
    public class TimeIt : IDisposable
    {
        private readonly string name;
        private readonly Stopwatch watch;

        public TimeIt(string name)
        {
            this.name = name;
            watch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            watch.Stop();
            Console.WriteLine($"{name} took {watch.Elapsed}");
        }
    }
}