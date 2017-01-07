using System;
using System.Reactive.Linq;

namespace MergeOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable1 = Observable.Interval(TimeSpan.FromMilliseconds(250)).Take(3);
            var observable2 = Observable.Interval(TimeSpan.FromMilliseconds(150)).Take(5)
                .Select(i => i + 100);

            observable1.Merge(observable2)
                .Subscribe(Console.WriteLine);

            Console.Read();
        }
    }
}