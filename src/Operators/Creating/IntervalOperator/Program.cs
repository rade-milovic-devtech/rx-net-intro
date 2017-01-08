using System;
using System.Reactive.Linq;

namespace IntervalOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(250));

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );

            Console.Read();
        }
    }
}